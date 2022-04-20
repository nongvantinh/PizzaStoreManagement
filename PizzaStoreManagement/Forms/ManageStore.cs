using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace PizzaStoreManagement.Forms
{
    public partial class ManageStore : Form
    {
        private List<Panel> _layers = new List<Panel>();
        private Controls.BuildingFloor _focusedFloor = null;

        public ManageStore()
        {
            InitializeComponent();

            RefreshView();
        }

        private void RefreshView()
        {
            for (int i = _layers.Count - 1; i >= 0; --i)
            {
                Panel layer = _layers[i];
                _layers.RemoveAt(i);
                layer.Dispose();
            }

            Utils.Database.ExecuteReader("SELECT floor_id, floor_description FROM pizza_store.floors ORDER BY floor_description;", new List<Tuple<SqlDbType, object>>(),
                reader =>
                {
                    for (int i = 0; reader.Read(); ++i)
                    {
                        InsertFloor((string)reader["floor_id"], (string)reader["floor_description"]);
                    }
                });
        }

        private void InsertFloor(string floorId, string floorDescription)
        {
            if (0 == _layers.Count || 6 == _layers[_layers.Count - 1].Controls.Count - 1)
            {
                Panel panel = new Panel();
                panel.BackColor = Color.FromArgb(53, 59, 72);
                panel.Dock = DockStyle.Top;
                panel.MinimumSize = new Size(900, 150);

                Panel childPanel = new Panel();
                childPanel.BackColor = Color.FromArgb(53, 59, 72);
                childPanel.Dock = DockStyle.Left;
                childPanel.Size = new Size(60, 150);

                panel.Controls.Add(childPanel);
                pnGrid.Controls.Add(panel);

                _layers.Add(panel);
                pnGrid.Controls.SetChildIndex(_layers[_layers.Count - 1], 0);
            }

            var floor = new Controls.BuildingFloor(floorId, floorDescription);
            floor.Dock = DockStyle.Left;
            floor.OnClickOnFloor += (button, id, description) =>
            {
                switch (button)
                {
                    case MouseButtons.Left:
                        Home.Instance.OpenChildForm(new ManageDinnerTable(floorId, floorDescription));
                        break;
                    case MouseButtons.Right:
                        {
                            _focusedFloor = floor;
                            ContextMenuStrip m = new ContextMenuStrip();
                            m.Items.Add("Cập Nhật").Click += Update;
                            m.Items.Add("Xóa").Click += Delete;
                            m.Show(new Point(Cursor.Position.X, Cursor.Position.Y));
                        }
                        break;
                }
            };

            _layers[_layers.Count - 1].Controls.Add(floor);
            _layers[_layers.Count - 1].Controls.SetChildIndex(floor, 0);
        }

        private void AddNew(object sender, EventArgs e)
        {
            var dialog = new Dialogs.ItemInfomation("Thêm Tầng", "Tên Tầng", Utils.ViewState.Create, () => { }, (value) =>
            {
                if (0 != Utils.Database.ExecuteScalar<int>("SELECT COUNT(floor_id) FROM pizza_store.floors AS name WHERE floor_description = @floor_description;", new List<Tuple<SqlDbType, object>>()
             {
                new Tuple<SqlDbType, object>(SqlDbType.NVarChar, value),
             }))
                {
                    MessageBox.Show($"{value} đã tồn tại trong cơ sở dữ liệu, hãy chọn tên khác.");
                }
                else
                {
                    Utils.Database.ExecuteNonQuery("INSERT INTO pizza_store.floors(floor_id, floor_description) VALUES(NEWID(), @floor_description);", new List<Tuple<SqlDbType, object>>()
                    {
                        new Tuple<SqlDbType, object>(SqlDbType.NVarChar, value)
                    });
                    RefreshView();
                }
            });
            Utils.ApplicationManager.ShowDialog(dialog);
        }

        private void Update(object sender, EventArgs e)
        {
            var dialog = new Dialogs.ItemInfomation("Chỉnh Sửa Thông Tin", "Tên Tầng", Utils.ViewState.Update, () => { }, (value) =>
            {
                if (0 != Utils.Database.ExecuteScalar<int>("SELECT COUNT(floor_description) FROM pizza_store.floors AS name WHERE floor_description = @floor_description AND floor_id != @floor_id;", new List<Tuple<SqlDbType, object>>()
            {
                new Tuple<SqlDbType, object>(SqlDbType.NVarChar, value),
                new Tuple<SqlDbType, object>(SqlDbType.Char, _focusedFloor.FloorId),
            }))
                {
                    MessageBox.Show($"Cập nhật thất bại. {value} đã tồn tại trong cơ sở dữ liệu, hãy chọn tên khác.");
                    return;
                }

                {
                    Utils.Database.ExecuteNonQuery("UPDATE pizza_store.floors SET floor_description = @floor_description WHERE floor_id = @floor_id;",
                         new List<Tuple<SqlDbType, object>>() {
                                     new Tuple<SqlDbType, object>(SqlDbType.NVarChar, value),
                                     new Tuple<SqlDbType, object>(SqlDbType.Char,_focusedFloor.FloorId),
                         });
                }
                RefreshView();
            });

            Utils.ApplicationManager.ShowDialog(dialog);
        }

        private void Delete(object sender, EventArgs e)
        {
            Utils.Database.ExecuteNonQuery("DELETE FROM pizza_store.dinner_tables WHERE table_at_floor = @floor_index; ",
    new List<Tuple<System.Data.SqlDbType, object>>()
    {
                    new Tuple<System.Data.SqlDbType, object>(System.Data.SqlDbType.Char, _focusedFloor.FloorId)
    });

            Utils.Database.ExecuteNonQuery("DELETE FROM pizza_store.floors WHERE floor_id = @floor_id;", new List<Tuple<SqlDbType, object>>()
            {
                new Tuple<SqlDbType, object>(SqlDbType.Char, _focusedFloor.FloorId)
            });
            RefreshView();
        }

        private void pnGrid_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip m = new ContextMenuStrip();
                m.Items.Add("Thêm tầng").Click += AddNew;
                m.Show(new Point(Cursor.Position.X, Cursor.Position.Y));

            }
        }

    }
}

using PizzaStoreManagement.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace PizzaStoreManagement.Forms
{
    public partial class ManageDinnerTable : Form
    {
        private List<Panel> _layers = new List<Panel>();
        private string _floorId;
        private string _floorDescription;
        private DinnerTable _focusedTable;

        public ManageDinnerTable()
        {
            InitializeComponent();
            Home.Instance.BackButtonVisible = true;
            Home.Instance.OnBtnBackClicked = () =>
            {
                Close();
                Home.Instance.OpenChildForm(new ManageStore());
                Home.Instance.BackButtonVisible = false;
            };
        }

        private void RefreshView()
        {
            for (int i = _layers.Count - 1; i >= 0; --i)
            {
                Panel layer = _layers[i];
                _layers.RemoveAt(i);
                layer.Dispose();
            }

            Utils.Database.ExecuteReader("SELECT table_id, table_description, table_at_floor FROM pizza_store.dinner_tables ORDER BY table_description;", new List<Tuple<SqlDbType, object>>(),
                reader =>
                {
                    for (int i = 0; reader.Read(); ++i)
                    {
                        InsertTable((string)reader["table_id"], (string)reader["table_description"], (string)reader["table_at_floor"]);
                    }
                });
        }

        public ManageDinnerTable(string floorId, string floorDescription)
            : this()
        {
            _floorId = floorId;
            _floorDescription = floorDescription;
            RefreshData();
        }

        private void RefreshData()
        {
            Utils.Database.ExecuteReader("SELECT table_id, table_description, table_at_floor FROM pizza_store.dinner_tables WHERE table_at_floor = @table_at_floor ORDER BY table_description;", new List<Tuple<SqlDbType, object>>()
            {
                new Tuple<SqlDbType, object>(SqlDbType.Char, _floorId)
            },
                reader =>
                {
                    for (int i = 0; reader.Read(); ++i)
                    {
                        InsertTable((string)reader["table_id"], (string)reader["table_description"], (string)reader["table_at_floor"]);
                    }
                });
        }

        private void InsertTable(string tableId, string tableDescription, string atFlorId)
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
                panel.MouseClick += pnGrid_MouseClick;
                _layers.Add(panel);
                pnGrid.Controls.SetChildIndex(_layers[_layers.Count - 1], 0);
            }

            var table = new Controls.DinnerTable(tableId, tableDescription, atFlorId);
            table.Dock = DockStyle.Left;
            table.OnClickOnTable += (button, id, description, atFloorId, numPerson) =>
            {
                switch (button)
                {
                    case MouseButtons.Left:
                        MessageBox.Show($"{description}, {numPerson}");
                        Home.Instance.OpenChildForm(new ManageOrder());
                        break;
                    case MouseButtons.Right:
                        {
                            _focusedTable = table;
                            ContextMenuStrip m = new ContextMenuStrip();
                            m.Items.Add("Cập Nhật").Click += Update;
                            m.Items.Add("Xóa").Click += Delete;
                            m.Show(new Point(Cursor.Position.X, Cursor.Position.Y));
                        }
                        break;
                }
            };
            _layers[_layers.Count - 1].Controls.Add(table);
            _layers[_layers.Count - 1].Controls.SetChildIndex(table, 0);
        }

        private void AddNew(object sender, EventArgs e)
        {
            var dialog = new Dialogs.ItemInfomation("Thêm Bàn", "Tên Bàn", Utils.ViewState.Create, () => { }, (value) =>
            {
                if (0 != Utils.Database.ExecuteScalar<int>("SELECT COUNT(table_id) FROM pizza_store.dinner_tables AS name WHERE table_description = @table_description AND table_at_floor = @table_at_floor;", new List<Tuple<SqlDbType, object>>()
             {
                new Tuple<SqlDbType, object>(SqlDbType.NVarChar, value),
                new Tuple<SqlDbType, object>(SqlDbType.Char, _floorId),
             }))
                {
                    MessageBox.Show($"{value} đã tồn tại trong cơ sở dữ liệu, hãy chọn tên khác.");
                }
                else
                {
                    Utils.Database.ExecuteNonQuery("INSERT INTO pizza_store.dinner_tables(table_id, table_description, table_at_floor) VALUES(NEWID(), @table_description, @table_at_floor);", new List<Tuple<SqlDbType, object>>()
                    {
                        new Tuple<SqlDbType, object>(SqlDbType.NVarChar, value),
                        new Tuple<SqlDbType, object>(SqlDbType.Char, _floorId),
                    });
                    RefreshView();
                }
            });
            Utils.ApplicationManager.ShowDialog(dialog);
        }

        private void Update(object sender, EventArgs e)
        {
            var dialog = new Dialogs.ItemInfomation("Chỉnh Sửa Thông Tin", "Tên Bàn", Utils.ViewState.Update, () => { }, (value) =>
            {
                if (0 != Utils.Database.ExecuteScalar<int>("SELECT COUNT(table_description) FROM pizza_store.dinner_tables AS name WHERE table_description = @table_description AND table_at_floor = @table_at_floor;", new List<Tuple<SqlDbType, object>>()
            {
                new Tuple<SqlDbType, object>(SqlDbType.NVarChar, value),
                new Tuple<SqlDbType, object>(SqlDbType.Char, _floorId),
            }))
                {
                    MessageBox.Show($"Cập nhật thất bại. {value} đã tồn tại trong cơ sở dữ liệu, hãy chọn tên khác.");
                    return;
                }

                {
                    Utils.Database.ExecuteNonQuery("UPDATE pizza_store.dinner_tables SET table_description = @table_description WHERE table_id = @table_id;",
                         new List<Tuple<SqlDbType, object>>() {
                                     new Tuple<SqlDbType, object>(SqlDbType.NVarChar, value),
                                     new Tuple<SqlDbType, object>(SqlDbType.Char,_focusedTable.TableId),
                         });
                }
                RefreshView();
            });

            Utils.ApplicationManager.ShowDialog(dialog);
        }

        private void Delete(object sender, EventArgs e)
        {
            Utils.Database.ExecuteNonQuery("DELETE FROM pizza_store.dinner_tables WHERE table_id = @table_id AND table_at_floor = @table_at_floor; ",
    new List<Tuple<System.Data.SqlDbType, object>>()
    {
                    new Tuple<System.Data.SqlDbType, object>(System.Data.SqlDbType.Char, _focusedTable.TableId),
                    new Tuple<System.Data.SqlDbType, object>(System.Data.SqlDbType.Char, _floorId)
    });

            RefreshView();
        }

        private void pnGrid_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip m = new ContextMenuStrip();
                m.Items.Add("Thêm Bàn").Click += AddNew;
                m.Show(new Point(Cursor.Position.X, Cursor.Position.Y));
            }
        }
    }
}

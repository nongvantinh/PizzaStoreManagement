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
        private int _numItem = 0;

        public ManageStore()
        {
            InitializeComponent();

            _numItem = Utils.Database.ExecuteScalar<int>("SELECT coalesce(MAX(floor_index), 0) FROM pizza_store.floors;", new List<Tuple<SqlDbType, object>>());

            RefreshData();
        }


        private void RefreshData()
        {
            Utils.Database.ExecuteReader("SELECT floor_index FROM pizza_store.floors ORDER BY floor_index;", new List<Tuple<SqlDbType, object>>(),
                reader =>
                {
                    for (int i = 0; reader.Read(); ++i)
                    {
                        InsertFloor((int)reader["floor_index"]);
                    }
                });
        }


        private void InsertFloor(int index)
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

            var floor = new Controls.BuildingFloor(index);
            floor.Dock = DockStyle.Left;
            floor.OnClickOnFloor += (floorIndex) => { Home.Instance.OpenChildForm(new ManageDinnerTable(floorIndex)); };
            _layers[_layers.Count - 1].Controls.Add(floor);
            _layers[_layers.Count - 1].Controls.SetChildIndex(floor, 0);

        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            InsertFloor(++_numItem);

            Utils.Database.ExecuteNonQuery("INSERT INTO pizza_store.floors(floor_index, floor_description)" +
                "VALUES(@floor_index, @floor_description);", new List<Tuple<SqlDbType, object>>()
                {
                    new Tuple<SqlDbType, object>(SqlDbType.Int, _numItem),
                    new Tuple<SqlDbType, object>(SqlDbType.NVarChar, string.Empty),
                });
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (0 == _layers.Count)
                return;

            var removedFloor = (Controls.BuildingFloor)_layers[_layers.Count - 1].Controls[0];

            Utils.Database.ExecuteNonQuery("DELETE FROM pizza_store.dinner_tables WHERE table_at_floor = @floor_index; ",
                new List<Tuple<System.Data.SqlDbType, object>>()
                {
                    new Tuple<System.Data.SqlDbType, object>(System.Data.SqlDbType.Int, removedFloor.FloorIndex)
                });

            Utils.Database.ExecuteNonQuery("DELETE FROM pizza_store.floors WHERE floor_index = @floor_index; ",
                new List<Tuple<System.Data.SqlDbType, object>>()
                {
                    new Tuple<System.Data.SqlDbType, object>(System.Data.SqlDbType.Int, removedFloor.FloorIndex)
                });

            _layers[_layers.Count - 1].Controls.Remove(removedFloor);
            removedFloor.Dispose();

            --_numItem;
            if (0 == _layers[_layers.Count - 1].Controls.Count - 1)
            {
                var removedPanel = _layers[_layers.Count - 1];
                _layers.Remove(removedPanel);
                removedPanel.Dispose();
            }
        }
    }
}

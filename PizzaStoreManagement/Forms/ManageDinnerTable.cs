using PizzaStoreManagement.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaStoreManagement.Forms
{
    public partial class ManageDinnerTable : Form
    {
        private Random _random = new Random();
        private List<Panel> _layers = new List<Panel>();
        private int _numItem = 0;
        private int _floorIndex;

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

        public ManageDinnerTable(int floorIndex)
            : this()
        {
            _floorIndex = floorIndex;
            RefreshData();
        }

        private void RefreshData()
        {
            Utils.Database.ExecuteReader("SELECT table_index FROM pizza_store.dinner_tables WHERE table_at_floor = @table_at_floor ORDER BY table_index;", new List<Tuple<SqlDbType, object>>()
            {
                new Tuple<SqlDbType, object>(SqlDbType.Int, _floorIndex)
            },
                reader =>
                {
                    for (int i = 0; reader.Read(); ++i)
                    {
                        InsertTable((int)reader["table_index"]);
                    }
                });
        }

        private void InsertTable(int index)
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

            var table = new Controls.DinnerTable(index, _random.Next(0, DinnerTable.MaxPerson));
            table.Dock = DockStyle.Left;
            table.OnClickOnTable += (tableIndex, numPerson) => { MessageBox.Show($"{tableIndex}, {numPerson}"); };
            _layers[_layers.Count - 1].Controls.Add(table);
            _layers[_layers.Count - 1].Controls.SetChildIndex(table, 0);
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            InsertTable(++_numItem);

            Utils.Database.ExecuteNonQuery("INSERT INTO pizza_store.dinner_tables(table_index, table_description, table_at_floor)" +
                "VALUES(@table_index, @table_description, @table_at_floor);", new List<Tuple<SqlDbType, object>>()
                {
                    new Tuple<SqlDbType, object>(SqlDbType.Int, _numItem),
                    new Tuple<SqlDbType, object>(SqlDbType.NVarChar, string.Empty),
                    new Tuple<SqlDbType, object>(SqlDbType.Int, _floorIndex),
                });
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (0 == _layers.Count)
                return;

            var removedFloor =(Controls.DinnerTable) _layers[_layers.Count - 1].Controls[0];
            Utils.Database.ExecuteNonQuery("DELETE FROM pizza_store.dinner_tables WHERE table_index = @table_index AND table_at_floor = @floor_index; ",
                new List<Tuple<System.Data.SqlDbType, object>>()
                {
                    new Tuple<System.Data.SqlDbType, object>(System.Data.SqlDbType.Int, removedFloor.TableIndex),
                    new Tuple<System.Data.SqlDbType, object>(System.Data.SqlDbType.Int, _floorIndex)
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

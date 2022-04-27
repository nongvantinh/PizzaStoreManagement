using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace PizzaStoreManagement.Forms
{
    public partial class Statistics : Form
    {
        private int currentMouseOverRow = 0;
        private int currentMouseOverColumn = 0;

        public Statistics()
        {
            InitializeComponent();

            InitGridView();
            RefreshDataGridView();

        }

        private void InitGridView()
        {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            for (int k = 0; k != dataGridView1.Columns.Count; ++k)
            {
                dataGridView1.Columns[k].ReadOnly = true;
            }
        }

        private void RefreshDataGridView()
        {
            dataGridView1.Rows.Clear();
            Utils.Database.ExecuteReader("SELECT order_id, floor_description, table_description, order_total, account_full_name" +
                " FROM pizza_store.orders " +
                " LEFT JOIN pizza_store.floors ON pizza_store.floors.floor_id = order_floor_id " +
                " LEFT JOIN pizza_store.dinner_tables ON pizza_store.dinner_tables.table_description = order_table_id " +
                " LEFT JOIN pizza_store.accounts ON pizza_store.accounts.account_id = order_employee_id;", new List<Tuple<SqlDbType, object>>(),
                reader =>
                {
                    for (int i = 0; reader.Read(); ++i)
                    {
                        List<object> objs = new List<object>();
                        objs.Add(reader["order_id"]);
                        objs.Add(reader["floor_description"]);
                        objs.Add(reader["table_description"]);
                        objs.Add(reader["order_total"]);
                        objs.Add(reader["account_full_name"]);

                        dataGridView1.Rows.Add(objs.ToArray());
                    }
                });
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                currentMouseOverRow = dataGridView1.HitTest(e.X, e.Y).RowIndex;
                currentMouseOverColumn = dataGridView1.HitTest(e.X, e.Y).ColumnIndex;

                ContextMenuStrip m = new ContextMenuStrip();

                if (-1 != currentMouseOverRow || -1 != currentMouseOverColumn)
                {
                    //m.Items.Add("Chi tiết").Click += Details;
                }

                m.Show(new Point(Cursor.Position.X, Cursor.Position.Y));
            }
        }

        private void Details(object sender, EventArgs e)
        {
        }

    }
}

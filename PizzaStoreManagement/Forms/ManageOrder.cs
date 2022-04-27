using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace PizzaStoreManagement.Forms
{
    public partial class ManageOrder : Form
    {
        public static ManageOrder Instance { get; private set; }
        int currentMouseOverRow = 0;
        int currentMouseOverColumn = 0;

        private string _orderId = string.Empty;
        private string _tableId = string.Empty;
        private int _total = 0;
        private string _floor_id;
        private string _floorDescription;

        public ManageOrder(string tableId, string orderId, string floorId, string floorDescription)
        {
            Instance = this;

            _tableId = tableId;
            _orderId = orderId;
            _floor_id = floorId;
            _floorDescription = floorDescription;

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

        public void RefreshDataGridView()
        {
            _total = 0;
            dataGridView1.Rows.Clear();
            Utils.Database.ExecuteReader("SELECT order_id, product_id, product_name, product_price, details_quantity, unit_name FROM pizza_store.orders " +
                " LEFT JOIN pizza_store.orders_details ON details_order_id = order_id " +
                " LEFT JOIN pizza_store.products ON product_id = details_product_id " +
                " LEFT JOIN pizza_store.unit ON unit_id = product_unit_id " +
                " WHERE order_id = @order_id;", new List<Tuple<SqlDbType, object>>()
                {
                    new Tuple<SqlDbType, object>(SqlDbType.Char, _orderId)
                },
                reader =>
                {
                    for (int i = 0; reader.Read(); ++i)
                    {
                        if (reader.IsDBNull(2))
                            continue;
                        List<object> objs = new List<object>();
                        objs.Add(reader["product_id"]);
                        objs.Add(reader["product_name"]);
                        int price = (int)reader["product_price"];
                        int quantity = (int)reader["details_quantity"];
                        _total += price * quantity;
                        objs.Add(price);
                        objs.Add(quantity);
                        objs.Add(reader["unit_name"]);
                        objs.Add(price * quantity);

                        dataGridView1.Rows.Add(objs.ToArray());
                    }
                });

            lbTotal.Text = _total.ToString();
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
                    m.Items.Add("Cập Nhật").Click += Update;
                    m.Items.Add("Xóa").Click += Delete;
                }

                m.Show(new Point(Cursor.Position.X, Cursor.Position.Y));
            }
        }

        private void Update(object sender, EventArgs e)
        {
            var dialog = new Dialogs.OrderProduct((string)dataGridView1.Rows[currentMouseOverRow].Cells[0].Value, (int)dataGridView1.Rows[currentMouseOverRow].Cells[3].Value, () => { }, (id, name, price, quantity, unit) =>
            {
                {
                    Utils.Database.ExecuteNonQuery("UPDATE pizza_store.orders_details SET details_quantity = @details_quantity " +
                        "WHERE details_order_id = @details_order_id AND details_product_id = @details_product_id;",
                         new List<Tuple<SqlDbType, object>>() {
                                     new Tuple<SqlDbType, object>(SqlDbType.Int, quantity),
                                        new Tuple<SqlDbType, object>(SqlDbType.Char, _orderId),
                                        new Tuple<SqlDbType, object>(SqlDbType.Char, dataGridView1.Rows[currentMouseOverRow].Cells[0].Value)
                         });
                }
                RefreshDataGridView();
            });

            Utils.ApplicationManager.ShowDialog(dialog);
        }

        private void Delete(object sender, EventArgs e)
        {
            Utils.Database.ExecuteNonQuery("DELETE FROM pizza_store.orders_details WHERE details_order_id = @details_order_id AND details_product_id = @details_product_id;", new List<Tuple<SqlDbType, object>>()
            {
                new Tuple<SqlDbType, object>(SqlDbType.Char, _orderId),
                new Tuple<SqlDbType, object>(SqlDbType.Char, dataGridView1.Rows[currentMouseOverRow].Cells[0].Value)
            });
            RefreshDataGridView();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var dialog = new Dialogs.ProductMenu(_orderId);
            Utils.ApplicationManager.ShowDialog(dialog);
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            var dialog = new Dialogs.CompletePayment(_orderId, _tableId, _floor_id, _floorDescription);
            Utils.ApplicationManager.ShowDialog(dialog);
        }
    }
}

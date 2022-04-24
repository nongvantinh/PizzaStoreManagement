using PizzaStoreManagement.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PizzaStoreManagement.Dialogs
{
    public partial class ProductMenu : Form
    {
        private List<Panel> _layers = new List<Panel>();
        private string _orderId;
        private Controls.NinePatchRectElement _focusedProduct;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public ProductMenu(string orderId)
        {
            _orderId = orderId;
            InitializeComponent();
            RefreshView();
        }

        private void lbHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void btnCloseDialog_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RefreshView()
        {
            for (int i = _layers.Count - 1; i >= 0; --i)
            {
                Panel layer = _layers[i];
                _layers.RemoveAt(i);
                layer.Dispose();
            }

            Utils.Database.ExecuteReader("SELECT product_id, product_avatar, product_name, product_price, kind_name, unit_name " +
                " FROM pizza_store.products LEFT JOIN pizza_store.product_kind ON pizza_store.product_kind.kind_id = product_kind_id " +
                " LEFT JOIN pizza_store.unit ON pizza_store.unit.unit_id = product_unit_id ORDER BY product_name;", new List<Tuple<SqlDbType, object>>(),
                reader =>
                {
                    for (int i = 0; reader.Read(); ++i)
                    {
                        var product = new Controls.NinePatchRectElement((string)reader["product_id"],
                            (byte[])reader["product_avatar"], (string)reader["product_name"],
                            (int)reader["product_price"], (string)reader["kind_name"], (string)reader["unit_name"]);

                        InsertTable(product);
                    }
                });
        }

        private void InsertTable(Controls.NinePatchRectElement product)
        {
            if (0 == _layers.Count || 8 == _layers[_layers.Count - 1].Controls.Count)
            {
                Panel pn = new Panel();
                pn.BackColor = Color.FromArgb(53, 59, 72);
                pn.Dock = DockStyle.Top;
                pn.Size = new Size(977, 30);
                pnGrid.Controls.Add(pn);
                _layers.Add(pn);
                pnGrid.Controls.SetChildIndex(_layers[_layers.Count - 1], 0);

                Panel panel = new Panel();
                panel.BackColor = Color.FromArgb(53, 59, 72);
                panel.Dock = DockStyle.Top;
                panel.MinimumSize = new Size(956, 260);

                pnGrid.Controls.Add(panel);
                _layers.Add(panel);
                pnGrid.Controls.SetChildIndex(_layers[_layers.Count - 1], 0);
            }

            Panel panel1 = _layers[_layers.Count - 1];

            Panel padding = new Panel();
            padding.BackColor = Color.FromArgb(53, 59, 72);
            padding.Dock = DockStyle.Left;
            padding.Size = new Size(35, 260);

            panel1.Controls.Add(padding);
            panel1.Controls.SetChildIndex(padding, 0);

            product.Dock = DockStyle.Left;
            product.OnClickOnProduct += (button, id, avatar, name, price, kind, unit) =>
            {
                switch (button)
                {
                    case MouseButtons.Left:
                        {
                            if (0 != Utils.Database.ExecuteScalar<int>("SELECT COUNT(*) FROM pizza_store.orders_details WHERE details_order_id = @details_order_id AND details_product_id = @details_product_id;",
                                new List<Tuple<SqlDbType, object>>() {
                                    new Tuple<SqlDbType, object>(SqlDbType.Char, _orderId),
                            new Tuple<SqlDbType, object>(SqlDbType.Char, id)
                                }))
                            {
                                Utils.Database.ExecuteNonQuery("UPDATE pizza_store.orders_details SET details_quantity = details_quantity + 1 WHERE details_order_id = @details_order_id AND details_product_id = @details_product_id;",
                                    new List<Tuple<SqlDbType, object>>()
                                    {
                                    new Tuple<SqlDbType, object>(SqlDbType.Char, _orderId),
                            new Tuple<SqlDbType, object>(SqlDbType.Char, id)
                                    });
                            }
                            else
                            {
                                Utils.Database.ExecuteNonQuery("INSERT INTO pizza_store.orders_details(details_order_id, details_product_id, details_quantity) VALUES( @details_order_id, @details_product_id, @details_quantity);", new List<Tuple<SqlDbType, object>>()
                    {
                        new Tuple<SqlDbType, object>(SqlDbType.Char, _orderId),
                        new Tuple<SqlDbType, object>(SqlDbType.Char, id),
                        new Tuple<SqlDbType, object>(SqlDbType.Int, 1),
                    });
                            }
                            ManageOrder.Instance.RefreshDataGridView();
                        }
                        break;
                    case MouseButtons.Right:
                        {
                            _focusedProduct = product;
                            ContextMenuStrip m = new ContextMenuStrip();
                            m.Items.Add("Tùy chọn").Click += Custom;
                            m.Show(new Point(Cursor.Position.X, Cursor.Position.Y));
                        }
                        break;
                }
            };

            panel1.Controls.Add(product);
            panel1.Controls.SetChildIndex(product, 0);
        }

        private void Custom(object sender, EventArgs e)
        {
            var dialog = new Dialogs.OrderProduct(_focusedProduct.Id, 1, () => { }, (id, name, price, quantity, unit) =>
            {
                if (0 != Utils.Database.ExecuteScalar<int>("SELECT COUNT(*) FROM pizza_store.orders_details WHERE details_order_id = @details_order_id AND details_product_id = @details_product_id;",
    new List<Tuple<SqlDbType, object>>() {
                                    new Tuple<SqlDbType, object>(SqlDbType.Char, _orderId),
                            new Tuple<SqlDbType, object>(SqlDbType.Char, id)
    }))
                {
                    Utils.Database.ExecuteNonQuery("UPDATE pizza_store.orders_details SET details_quantity = @details_quantity WHERE details_order_id = @details_order_id AND details_product_id = @details_product_id;",
                        new List<Tuple<SqlDbType, object>>()
                        {
                        new Tuple<SqlDbType, object>(SqlDbType.Int, quantity),
                                    new Tuple<SqlDbType, object>(SqlDbType.Char, _orderId),
                            new Tuple<SqlDbType, object>(SqlDbType.Char, id)
                        });
                }
                else
                {
                    Utils.Database.ExecuteNonQuery("INSERT INTO pizza_store.orders_details(details_order_id, details_product_id, details_quantity) VALUES( @details_order_id, @details_product_id, @details_quantity);", new List<Tuple<SqlDbType, object>>()
                    {
                        new Tuple<SqlDbType, object>(SqlDbType.Char, _orderId),
                        new Tuple<SqlDbType, object>(SqlDbType.Char, id),
                        new Tuple<SqlDbType, object>(SqlDbType.Int, quantity),
                    });
                }
                    ManageOrder.Instance.RefreshDataGridView();
            });
            Utils.ApplicationManager.ShowDialog(dialog);
        }
    }
}

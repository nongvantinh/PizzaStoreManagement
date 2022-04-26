using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaStoreManagement.Dialogs
{
    public partial class CompletePayment : Form
    {
        private string _orderId;
        private int _total = 0;
        private int _tempSum = 0;
        private List<Utils.Product> _products = new List<Utils.Product>();

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void btnCloseDialog_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void lbHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public CompletePayment()
        {
            InitializeComponent();
        }

        public CompletePayment(string orderId)
            : this()
        {
            this._orderId = orderId;

            InitGridView();
            RefreshDataGridView();
            LoadPromotions();
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
            _products.Clear();
            Utils.Database.ExecuteReader("SELECT order_id, product_id, product_name, kind_name, product_price, details_quantity, unit_name FROM pizza_store.orders " +
                " LEFT JOIN pizza_store.orders_details ON details_order_id = order_id " +
                " LEFT JOIN pizza_store.products ON product_id = details_product_id " +
                " LEFT JOIN pizza_store.unit ON unit_id = product_unit_id " +
" LEFT JOIN pizza_store.product_kind ON pizza_store.product_kind.kind_id = product_kind_id " +
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

                        _products.Add(new Utils.Product((string)reader["product_name"], (string)reader["kind_name"], (int)reader["product_price"], (int)reader["details_quantity"]));
                        dataGridView1.Rows.Add(objs.ToArray());
                    }
                });

            lbTotal.Text = _total.ToString();
            _tempSum = _total;
        }

        private void LoadPromotions()
        {
            Utils.Database.ExecuteReader("SELECT promotion_id, promotion_content, " +
                " promotion_kind, product_name, kind_name, promotion_percent_discount, " +
" promotion_cash_discount, promotion_max_discount, promotion_condition, " +
" promotion_start_date, promotion_end_date, promotion_incremental FROM pizza_store.promotions " +
" LEFT JOIN pizza_store.products ON pizza_store.products.product_id = promotion_product_id " +
" LEFT JOIN pizza_store.product_kind ON pizza_store.product_kind.kind_id = promotion_product_id " +
" WHERE GETDATE() <= promotion_end_date;", new List<Tuple<SqlDbType, object>>(),
reader =>
{
    for (; reader.Read();)
    {
        var checkBox = new Controls.PromotionCheckBox(
            (string)reader["promotion_id"],
            (string)reader["promotion_content"],
            (string)reader["promotion_kind"],
            (string)("Theo mặt hàng" == (string)reader["promotion_kind"] ?
        reader["kind_name"] : ("Sản phẩm" == (string)reader["promotion_kind"] ? reader["product_name"] : string.Empty)),
            (int)reader["promotion_percent_discount"],
            (int)reader["promotion_cash_discount"],
            (int)reader["promotion_max_discount"],
            (int)reader["promotion_condition"],
            (DateTime)reader["promotion_start_date"],
            (DateTime)reader["promotion_end_date"],
            (1 == (int)reader["promotion_condition"]) ? true : false,
            (isChecked, kind, name, percentDiscount, cashDiscount, maxDiscount, condition, incremental) =>
            {
                ApplyCode(name, condition, kind, percentDiscount, cashDiscount, maxDiscount, isChecked);
            }
            );

        checkBox.Dock = DockStyle.Top;
        pnPromotions.Controls.Add(checkBox);
        pnPromotions.Controls.SetChildIndex(checkBox, 0);
    }
});
        }

        private void ApplyCode(string name, int condition, string kind, int percentDiscount, int cashDiscount, int maxDiscount, bool isChecked)
        {
            if (_total < condition)
                return;
            switch (kind)
            {
                case "Tất cả sản phẩm":
                    {
                        int sum = (_total * percentDiscount) / 100;
                        sum += cashDiscount;

                        sum = (-1 != maxDiscount && maxDiscount < sum) ? maxDiscount : sum;

                        if (isChecked)
                            _tempSum -= sum;
                        else
                            _tempSum += sum;

                        lbTotal.Text = _tempSum.ToString();
                    }
                    break;
                case "Sản phẩm":
                    {
                        int total = 0;
                        for (int i = 0; i != _products.Count; ++i)
                        {
                            if (_products[i].Name == name)
                                total += _products[i].Price * _products[i].Quantity;
                        }

                        int sum = (total * percentDiscount) / 100;
                        sum += cashDiscount;

                        sum = (-1 != maxDiscount && maxDiscount < sum) ? maxDiscount : sum;

                        if (isChecked)
                            _tempSum -= sum;
                        else
                            _tempSum += sum;

                        lbTotal.Text = _tempSum.ToString();
                    }
                    break;
                case "Theo mặt hàng":
                    {
                        int total = 0;
                        for (int i = 0; i != _products.Count; ++i)
                        {
                            if (_products[i].Kind == kind)
                                total += _products[i].Price * _products[i].Quantity;
                        }

                        int sum = (total * percentDiscount) / 100;
                        sum += cashDiscount;

                        sum = (-1 != maxDiscount && maxDiscount < sum) ? maxDiscount : sum;

                        if (isChecked)
                            _tempSum -= sum;
                        else
                            _tempSum += sum;

                        lbTotal.Text = _tempSum.ToString();
                    }
                    break;
            }
        }

        private void btnApplyVoucher_Click(object sender, EventArgs e)
        {
            if (tbVoucherCode.Texts == String.Empty)
                return;

            Utils.Database.ExecuteReader("SELECT voucher_id, voucher_code, " +
    " voucher_content, voucher_kind, product_name, kind_name, voucher_percent_discount, " +
" voucher_cash_discount, voucher_max_discount, voucher_condition, " +
" voucher_number_of_uses, voucher_expiry, voucher_incremental FROM pizza_store.vouchers " +
" LEFT JOIN pizza_store.products ON pizza_store.products.product_id = voucher_product_id " +
" LEFT JOIN pizza_store.product_kind ON pizza_store.product_kind.kind_id = voucher_product_id " +
" WHERE voucher_code = @voucher_code;", new List<Tuple<SqlDbType, object>>() { new Tuple<SqlDbType, object>(SqlDbType.Char, tbVoucherCode.Texts) },
reader =>
{
    while (reader.Read())
    {
        string id = (string)reader["voucher_id"];
        string code = (string)reader["voucher_code"];
        string content = (string)reader["voucher_content"];
        string kind = (string)reader["voucher_kind"];
        string name = (string)("Theo mặt hàng" == kind ?
            reader["kind_name"] : ("Sản phẩm" == kind ? reader["product_name"] : string.Empty));
        int percentDiscount = (int)reader["voucher_percent_discount"];
        int cashDiscount = (int)reader["voucher_cash_discount"];
        int maxDiscount = (int)reader["voucher_max_discount"];
        int condition = (int)reader["voucher_condition"];
        int numberOfUses = (int)reader["voucher_number_of_uses"];
        DateTime expiry = (DateTime)reader["voucher_expiry"];
        int incremental = (int)reader["voucher_incremental"];

        if (expiry < DateTime.Now)
        {
            rtbVoucherContent.Text = "Voucher đã hết hạn sử dụng";
            return;
        }

        if (numberOfUses <= 0)
        {
            rtbVoucherContent.Text = "Voucher đã hết lượt sử dụng";
            return;
        }

        rtbVoucherContent.Text = content;
        ApplyCode(name, condition, kind, percentDiscount, cashDiscount, maxDiscount, true);

    }
});
        }
    }
}

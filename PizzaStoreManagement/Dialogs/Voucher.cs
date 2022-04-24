using PizzaStoreManagement.Utils;
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
    public partial class Voucher : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private Action _onBtnClosePressed;
        private Action _onBtnConfirmPressed;
        private ViewState _view;
        private string _voucherId;
        private Dictionary<string, string> _products = new Dictionary<string, string>();
        private static Random random = new Random();

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public Voucher()
        {
            InitializeComponent();

            cbkindOfVoucher.Items.Clear();
            cbkindOfVoucher.Items.AddRange(new List<string>() { "Tất cả sản phẩm", "Theo mặt hàng", "Sản phẩm" }.ToArray());
            cbkindOfVoucher.SelectedItem = "Tất cả sản phẩm";
            lbProductName.Hide();
            cbProductName.Hide();
        }

        public Voucher(string voucherId, Utils.ViewState view, Action onBtnClosePressed, Action onBtnConfirmPressed)
            : this()
        {
            _view = view;
            this._voucherId = voucherId;
            this._onBtnClosePressed = onBtnClosePressed;
            this._onBtnConfirmPressed = onBtnConfirmPressed;
            if (Utils.ViewState.Create == view)
            {
                lbCode.Hide();
                tbCode.Hide();
            }
                if (Utils.ViewState.Update == view)
            {
                Utils.Database.ExecuteReader("SELECT voucher_id, voucher_code, " +
                    " voucher_content, voucher_kind, product_name, kind_name, voucher_percent_discount, " +
    " voucher_cash_discount, voucher_max_discount, voucher_condition, " +
    " voucher_number_of_uses, voucher_expiry, voucher_incremental FROM pizza_store.vouchers " +
    " LEFT JOIN pizza_store.products ON pizza_store.products.product_id = voucher_product_id " +
    " LEFT JOIN pizza_store.product_kind ON pizza_store.product_kind.kind_id = voucher_product_id " +
    " WHERE voucher_id = @voucher_id;", new List<Tuple<SqlDbType, object>>() { new Tuple<SqlDbType, object>(SqlDbType.Char, _voucherId) },
reader =>
{
    for (int i = 0; reader.Read(); ++i)
    {
        rtbContents.Text = (string)reader["voucher_content"];
        cbkindOfVoucher.SelectedItem = reader["voucher_kind"];
        cbProductName.SelectedItem = ("Theo mặt hàng" == (string)reader["voucher_kind"]) ?
        reader["kind_name"] : reader["product_name"];
        tbPercentDiscount.Texts = reader["voucher_percent_discount"].ToString();
        tbCashDiscount.Texts = reader["voucher_cash_discount"].ToString();
        tbMaxDiscount.Texts = reader["voucher_max_discount"].ToString();
        tbCondition.Texts = reader["voucher_condition"].ToString();
        tbCondition.Texts = reader["voucher_number_of_uses"].ToString();
        dtpEndDate.Value = (DateTime)reader["voucher_expiry"];
        cbIncremental.Checked = (1 == (int)reader["voucher_incremental"]) ? true : false;

        tbNumberOfUses.Texts = reader["voucher_number_of_uses"].ToString();
        tbCode.Texts = reader["voucher_code"].ToString();
    }
});
            }
        }

        private void lbHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCloseDialog_Click(object sender, EventArgs e)
        {
            _onBtnClosePressed?.Invoke();
            Close();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            _onBtnClosePressed?.Invoke();
            Close();

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            int percentDiscount = (string.Empty == tbPercentDiscount.Texts) ? 0 : int.Parse(tbPercentDiscount.Texts);
            int cashDiscount = (string.Empty == tbCashDiscount.Texts) ? 0 : int.Parse(tbCashDiscount.Texts);
            int maxDiscount = (string.Empty == tbMaxDiscount.Texts) ? 0 : int.Parse(tbMaxDiscount.Texts);
            int conditionDiscount = (string.Empty == tbCondition.Texts) ? 0 : int.Parse(tbCondition.Texts);
            int numberOfUses = (string.Empty == tbNumberOfUses.Texts) ? 0 : int.Parse(tbNumberOfUses.Texts);
            string productId = (null == cbProductName.SelectedItem) ? "NULL" : _products[(string)cbProductName.SelectedItem];

            switch (_view)
            {
                case ViewState.Details:
                    break;
                case ViewState.Update:
                    {
                        Utils.Database.ExecuteNonQuery("UPDATE pizza_store.vouchers SET voucher_code = @voucher_code, voucher_content = @voucher_content," +
                            " voucher_kind = @voucher_kind, voucher_product_id = @voucher_product_id, " +
                            " voucher_percent_discount = @voucher_percent_discount, voucher_cash_discount = @voucher_cash_discount, " +
                            " voucher_max_discount = @voucher_max_discount, voucher_condition = @voucher_condition, " +
                            " voucher_number_of_uses = @voucher_number_of_uses, voucher_expiry = @voucher_expiry, voucher_incremental = @voucher_incremental " +
                            " WHERE voucher_id = @voucher_id;",
                            new List<Tuple<SqlDbType, object>>()
                            {
                                new Tuple<SqlDbType, object>(SqlDbType.NVarChar, tbCode.Texts),
                                new Tuple<SqlDbType, object>(SqlDbType.NVarChar, rtbContents.Text),
                                new Tuple<SqlDbType, object>(SqlDbType.NVarChar, cbkindOfVoucher.SelectedItem),

                                new Tuple<SqlDbType, object>(SqlDbType.Char, productId),
                                new Tuple<SqlDbType, object>(SqlDbType.Int, percentDiscount),
                                new Tuple<SqlDbType, object>(SqlDbType.Int, cashDiscount),
                                new Tuple<SqlDbType, object>(SqlDbType.Int, maxDiscount),
                                new Tuple<SqlDbType, object>(SqlDbType.Int, conditionDiscount),
                                new Tuple<SqlDbType, object>(SqlDbType.Int, int.Parse(tbNumberOfUses.Texts)),

                                new Tuple<SqlDbType, object>(SqlDbType.DateTime, dtpEndDate.Value),
                                new Tuple<SqlDbType, object>(SqlDbType.Int, cbIncremental.Checked),

                                new Tuple<SqlDbType, object>(SqlDbType.Char, _voucherId),
                            });
                    }
                    break;
                case ViewState.Create:
                    {
                        Utils.Database.ExecuteNonQuery("INSERT INTO pizza_store.vouchers(voucher_id, voucher_code, voucher_content, " +
                                    " voucher_kind, voucher_product_id, voucher_percent_discount, voucher_cash_discount, voucher_max_discount, " +
                                    " voucher_condition, voucher_number_of_uses, voucher_expiry, voucher_incremental) VALUES("+
                                    " @voucher_id, @voucher_code, @voucher_content, " +
                                    " @voucher_kind, @voucher_product_id, @voucher_percent_discount, @voucher_cash_discount, @voucher_max_discount, " +
                                    " @voucher_condition, @voucher_number_of_uses, @voucher_expiry, @voucher_incremental);",
                                    new List<Tuple<SqlDbType, object>>()
                                    {
                                new Tuple<SqlDbType, object>(SqlDbType.Char, Guid.NewGuid().ToString()),
                                new Tuple<SqlDbType, object>(SqlDbType.NChar, RandomString(6)),
                                new Tuple<SqlDbType, object>(SqlDbType.NVarChar, rtbContents.Text),
                                new Tuple<SqlDbType, object>(SqlDbType.NVarChar, cbkindOfVoucher.SelectedItem),

                                new Tuple<SqlDbType, object>(SqlDbType.Char, productId),
                                new Tuple<SqlDbType, object>(SqlDbType.Int, percentDiscount),
                                new Tuple<SqlDbType, object>(SqlDbType.Int, cashDiscount),
                                new Tuple<SqlDbType, object>(SqlDbType.Int, maxDiscount),
                                new Tuple<SqlDbType, object>(SqlDbType.Int, conditionDiscount),
                                new Tuple<SqlDbType, object>(SqlDbType.Int, numberOfUses),

                                new Tuple<SqlDbType, object>(SqlDbType.DateTime, dtpEndDate.Value),
                                new Tuple<SqlDbType, object>(SqlDbType.Int, cbIncremental.Checked),
                                    }); ;
                    }
                    break;
            }
            _onBtnConfirmPressed?.Invoke();
            Close();
        }

        private void cbkindOfPromotion_OnSelectedIndexChanged(object sender, EventArgs e)
        {

            switch (cbkindOfVoucher.SelectedItem)
            {
                case "Theo mặt hàng":
                    _products.Clear();
                    Utils.Database.ExecuteReader("SELECT kind_id, kind_name FROM pizza_store.product_kind; " +
    ";", new List<Tuple<SqlDbType, object>>(),
    reader =>
    {
        while (reader.Read())
            _products.Add((string)reader["kind_name"], (string)reader["kind_id"]);

    });
                    cbProductName.Items.AddRange(_products.Keys.ToArray());
                    lbProductName.Show();
                    cbProductName.Show();
                    break;
                case "Sản phẩm":
                    {
                        _products.Clear();
                        Utils.Database.ExecuteReader("SELECT product_id, product_name FROM pizza_store.products " +
                            ";", new List<Tuple<SqlDbType, object>>(),
                            reader =>
                            {
                                while (reader.Read())
                                    _products.Add((string)reader["product_name"], (string)reader["product_id"]);

                            });
                        cbProductName.Items.AddRange(_products.Keys.ToArray());
                        lbProductName.Show();
                        cbProductName.Show();
                    }
                    break;
                default:
                    lbProductName.Hide();
                    cbProductName.Hide();
                    break;
            }
        }
    }
}

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
    public partial class Promotion : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private Action _onBtnClosePressed;
        private Action _onBtnConfirmPressed;
        private ViewState _view;
        private string _promotionId;
        private Dictionary<string, string> _products = new Dictionary<string, string>();

        public Promotion()
        {
            InitializeComponent();

            cbkindOfPromotion.Items.Clear();
            cbkindOfPromotion.Items.AddRange(new List<string>() { "Tất cả sản phẩm", "Theo mặt hàng", "Sản phẩm" }.ToArray());
            cbkindOfPromotion.SelectedItem = "Tất cả sản phẩm";
            lbProductName.Hide();
            cbProductName.Hide();
        }

        public Promotion(string promotionId, Utils.ViewState view, Action onBtnClosePressed, Action onBtnConfirmPressed)
            : this()
        {
            _view = view;
            this._promotionId = promotionId;
            this._onBtnClosePressed = onBtnClosePressed;
            this._onBtnConfirmPressed = onBtnConfirmPressed;

            if (Utils.ViewState.Update == view)
            {
                Utils.Database.ExecuteReader("SELECT promotion_id, promotion_content, " +
                    " promotion_kind, product_name, kind_name, promotion_percent_discount, " +
    " promotion_cash_discount, promotion_max_discount, promotion_condition, " +
    " promotion_start_date, promotion_end_date, promotion_incremental FROM pizza_store.promotions " +
    " LEFT JOIN pizza_store.products ON pizza_store.products.product_id = promotion_product_id " +
    " LEFT JOIN pizza_store.product_kind ON pizza_store.product_kind.kind_id = promotion_product_id " +
    " WHERE promotion_id = @promotion_id;", new List<Tuple<SqlDbType, object>>() { new Tuple<SqlDbType, object>(SqlDbType.Char, _promotionId) },
reader =>
{
    for (int i = 0; reader.Read(); ++i)
    {
        rtbContents.Text = (string)reader["promotion_content"];
        cbkindOfPromotion.SelectedItem = reader["promotion_kind"];
        cbProductName.SelectedItem = ("Theo mặt hàng" == (string)reader["promotion_kind"]) ?
        reader["kind_name"] : reader["product_name"];
        tbPercentDiscount.Texts = reader["promotion_percent_discount"].ToString();
        tbCashDiscount.Texts = reader["promotion_cash_discount"].ToString();
        tbMaxDiscount.Texts = reader["promotion_max_discount"].ToString();
        tbCondition.Texts = reader["promotion_condition"].ToString();
        dtpStartDate.Value = (DateTime)reader["promotion_start_date"];
        dtpEndDate.Value = (DateTime)reader["promotion_end_date"];
        cbIncremental.Checked = (1 == (int)reader["promotion_incremental"]) ? true : false;
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
            string productId = (null == cbProductName.SelectedItem) ? "NULL" : _products[(string)cbProductName.SelectedItem];

            switch (_view)
            {
                case ViewState.Details:
                    break;
                case ViewState.Update:
                    {
                        Utils.Database.ExecuteNonQuery("UPDATE pizza_store.promotions SET promotion_content = @promotion_content," +
                            " promotion_kind = @promotion_kind, promotion_product_id = @promotion_product_id, " +
                            " promotion_percent_discount = @promotion_percent_discount, promotion_cash_discount = @promotion_cash_discount, " +
                            " promotion_max_discount = @promotion_max_discount, promotion_condition = @promotion_condition, " +
                            " promotion_start_date = @promotion_start_date, promotion_end_date = @promotion_end_date, promotion_incremental = @promotion_incremental " +
                            " WHERE promotion_id = @promotion_id;",
                            new List<Tuple<SqlDbType, object>>()
                            {
                                new Tuple<SqlDbType, object>(SqlDbType.NVarChar, rtbContents.Text),
                                new Tuple<SqlDbType, object>(SqlDbType.NVarChar, cbkindOfPromotion.SelectedItem),

                                new Tuple<SqlDbType, object>(SqlDbType.Char, productId),
                                new Tuple<SqlDbType, object>(SqlDbType.Int, percentDiscount),
                                new Tuple<SqlDbType, object>(SqlDbType.Int, cashDiscount),
                                new Tuple<SqlDbType, object>(SqlDbType.Int, maxDiscount),
                                new Tuple<SqlDbType, object>(SqlDbType.Int, conditionDiscount),

                                new Tuple<SqlDbType, object>(SqlDbType.DateTime, dtpStartDate.Value),
                                new Tuple<SqlDbType, object>(SqlDbType.DateTime, dtpEndDate.Value),
                                new Tuple<SqlDbType, object>(SqlDbType.Int, cbIncremental.Checked),

                                new Tuple<SqlDbType, object>(SqlDbType.Char, _promotionId),
                            });
                    }
                    break;
                case ViewState.Create:
                    {
                        Utils.Database.ExecuteNonQuery("INSERT INTO pizza_store.promotions(promotion_id, promotion_content, promotion_kind, " +
                                    " promotion_product_id, promotion_percent_discount, promotion_cash_discount, promotion_max_discount, promotion_condition, " +
                                    " promotion_start_date, promotion_end_date, promotion_incremental) VALUES(" +
                                    " @promotion_id, @promotion_content, @promotion_kind, " +
                                    " @promotion_product_id, @promotion_percent_discount, @promotion_cash_discount, @promotion_max_discount, @promotion_condition, " +
                                    " @promotion_start_date, @promotion_end_date, @promotion_incremental);",
                                    new List<Tuple<SqlDbType, object>>()
                                    {
                                new Tuple<SqlDbType, object>(SqlDbType.Char, Guid.NewGuid().ToString()),
                                new Tuple<SqlDbType, object>(SqlDbType.NVarChar, rtbContents.Text),
                                new Tuple<SqlDbType, object>(SqlDbType.NVarChar, cbkindOfPromotion.SelectedItem),

                                new Tuple<SqlDbType, object>(SqlDbType.Char, productId),
                                new Tuple<SqlDbType, object>(SqlDbType.Int, percentDiscount),
                                new Tuple<SqlDbType, object>(SqlDbType.Int, cashDiscount),
                                new Tuple<SqlDbType, object>(SqlDbType.Int, maxDiscount),
                                new Tuple<SqlDbType, object>(SqlDbType.Int, conditionDiscount),

                                new Tuple<SqlDbType, object>(SqlDbType.DateTime, dtpStartDate.Value),
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
            switch (cbkindOfPromotion.SelectedItem)
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

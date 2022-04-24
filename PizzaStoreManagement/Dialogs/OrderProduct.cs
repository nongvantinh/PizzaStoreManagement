using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PizzaStoreManagement.Dialogs
{
    public partial class OrderProduct : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private Action _onBtnClosePressed;
        private Action<string, string, int, int, string> _onBtnConfirmPressed;
        private string _productId;
        private int _quantity = 1;
        private int _price = 0;

        public OrderProduct(string productId, int quantity, Action onBtnCloseClick, Action<string, string, int, int, string> onBtnConfirmClick)
        {
            InitializeComponent();

            _productId = productId;
            _quantity = quantity;
            _onBtnClosePressed = onBtnCloseClick;
            _onBtnConfirmPressed = onBtnConfirmClick;

            Utils.Database.ExecuteReader("SELECT product_avatar, product_name, " +
    "  (SELECT kind_name FROM pizza_store.product_kind WHERE kind_id = product_kind_id) as kind_name," +
    " (SELECT unit_name FROM pizza_store.unit WHERE unit_id = product_unit_id) AS unit_name, product_price" +
    " FROM pizza_store.products WHERE product_id = @product_id;", new List<Tuple<SqlDbType, object>>()
    {
                                new Tuple<SqlDbType, object>(SqlDbType.NVarChar, _productId),
    }, reader =>
    {
        while (reader.Read())
        {
            pbAvatar.Image = Utils.ApplicationManager.ByteArrayToImage((byte[])reader["product_avatar"]);
            tbName.Text = (string)reader["product_name"];
            tbKind.Text = (string)reader["kind_name"];
            tbUnit.Text = (string)reader["unit_name"];
            tbQuantity.Texts = _quantity.ToString();
            tbPrice.Text = reader["product_price"].ToString();
            _price = (int)reader["product_price"];
        }
    });
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
            _onBtnConfirmPressed?.Invoke(_productId, tbName.Text, int.Parse(tbPrice.Text), int.Parse(tbQuantity.Texts), tbUnit.Text);
            Close();
        }

        private void tbQuantity__TextChanged(object sender, EventArgs e)
        {
            if (tbQuantity.Texts != String.Empty)
                tbPrice.Text = (int.Parse(tbQuantity.Texts) * _price).ToString();
        }
    }
}

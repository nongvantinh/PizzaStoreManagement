using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Windows.Forms;

namespace PizzaStoreManagement.Dialogs
{
    public partial class ProductInfomation : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private OpenFileDialog _fileDialog = new OpenFileDialog();
        private Dictionary<string, Guid> _units = new Dictionary<string, Guid>();
        private Action _onBtnClosePressed;
        private Action _onBtnConfirmPressed;
        private string _productId;
        private Utils.ViewState _view;

        public ProductInfomation(Utils.ViewState view, string productId, Action onBtnCloseClick, Action onBtnConfirmClick)
        {
            InitializeComponent();

            Utils.Database.ExecuteReader("SELECT unit_id, unit_name FROM pizza_store.unit;", new List<Tuple<SqlDbType, object>>(),
    reader => { while (reader.Read()) _units.Add((string)reader["unit_name"], new Guid((string)reader["unit_id"])); });

            cbKind.Items.AddRange(new List<string>() { "Pizza", "Đồ uống" }.ToArray());
            cbUnit.Items.AddRange(_units.Keys.ToArray());

            _view = view;
            _productId = productId;
            _onBtnClosePressed = onBtnCloseClick;
            _onBtnConfirmPressed = onBtnConfirmClick;

            switch (_view)
            {
                case Utils.ViewState.Details:
                case Utils.ViewState.Update:
                    {
                        Utils.Database.ExecuteReader("SELECT product_avatar, product_name, product_kind," +
                            " (SELECT unit_name FROM pizza_store.unit WHERE unit_id = product_unit_id) AS unit_name, product_price" +
                            " FROM pizza_store.products WHERE product_id = @product_id;", new List<Tuple<SqlDbType, object>>()
                            {
                                new Tuple<SqlDbType, object>(SqlDbType.NVarChar, _productId),
                            }, reader =>
                            {
                                while (reader.Read())
                                {
                                    pbAvatar.Image = Utils.ApplicationManager.ByteArrayToImage((byte[])reader["product_avatar"]);
                                    tbName.Texts = (string)reader["product_name"];
                                    cbKind.SelectedItem = (string)reader["product_kind"];
                                    cbUnit.SelectedItem = (string)reader["unit_name"];
                                    tbPrice.Texts = reader["product_price"].ToString();
                                }
                            });
                    }
                    break;
                case Utils.ViewState.Create:
                    break;
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
            switch (_view)
            {
                case Utils.ViewState.Details:
                case Utils.ViewState.Update:
                    if (0 != Utils.Database.ExecuteScalar<int>("SELECT COUNT(product_name) FROM pizza_store.products AS product_name WHERE product_name = @product_name AND product_id != @product_id;", new List<Tuple<SqlDbType, object>>()
             {
                new Tuple<SqlDbType, object>(SqlDbType.NVarChar, tbName.Texts),
                new Tuple<SqlDbType, object>(SqlDbType.Char, _productId)
             }))
                    {
                        MessageBox.Show($"{tbName.Texts} đã tồn tại trong cơ sở dữ liệu, hãy chọn tài khoản khác.");
                    }
                    else
                    {
                        Utils.Database.ExecuteNonQuery("UPDATE pizza_store.products SET product_avatar = @product_avatar, product_name = @product_name, product_kind = @product_kind, " +
                            " product_unit_id = @product_unit_id, product_price = @product_price WHERE product_id = @product_id;", new List<Tuple<SqlDbType, object>>()
                            {
                                     new Tuple<SqlDbType, object>(SqlDbType.Image, Utils.ApplicationManager.ImageToByteArray(pbAvatar.Image)),
                                     new Tuple<SqlDbType, object>(SqlDbType.NVarChar, tbName.Texts),
                                     new Tuple<SqlDbType, object>(SqlDbType.NVarChar, cbKind.SelectedItem),
                                     new Tuple<SqlDbType, object>(SqlDbType.Char, _units[(string)cbUnit.SelectedItem].ToString()),
                                     new Tuple<SqlDbType, object>(SqlDbType.Int, int.Parse(tbPrice.Texts)),

                                     new Tuple<SqlDbType, object>(SqlDbType.Char, _productId),
                            });
                    }
                    break;
                case Utils.ViewState.Create:
                    if (0 != Utils.Database.ExecuteScalar<int>("SELECT COUNT(product_name) FROM pizza_store.products AS name WHERE product_name = @product_name;", new List<Tuple<SqlDbType, object>>()
             {
                new Tuple<SqlDbType, object>(SqlDbType.NVarChar, tbName.Texts)
             }))
                    {
                        MessageBox.Show($"{tbName.Texts} đã tồn tại trong cơ sở dữ liệu, hãy chọn tài khoản khác.");
                    }
                    else
                    {
                        Utils.Database.ExecuteNonQuery("INSERT INTO pizza_store.products(product_id, product_avatar, product_name, product_kind, " +
                            "product_unit_id, product_price) VALUES(NEWID(), @product_avatar, @product_name, @product_kind, @product_unit_id, @product_price);",
                             new List<Tuple<SqlDbType, object>>() {
                                                                      new Tuple<SqlDbType, object>(SqlDbType.Image, Utils.ApplicationManager.ImageToByteArray(pbAvatar.Image)),
                                     new Tuple<SqlDbType, object>(SqlDbType.NVarChar, tbName.Texts),
                                     new Tuple<SqlDbType, object>(SqlDbType.NVarChar, cbKind.SelectedItem),
                                     new Tuple<SqlDbType, object>(SqlDbType.Char, _units[(string)cbUnit.SelectedItem].ToString()),
                                     new Tuple<SqlDbType, object>(SqlDbType.Int, int.Parse(tbPrice.Texts)),
                             });
                    }
                    break;
            }

            _onBtnConfirmPressed?.Invoke();
            Close();
        }

        private void pbAvatar_Click(object sender, EventArgs e)
        {
            _fileDialog.Filter = "jpg or png files(*.jpg, *.png)|*.jpg;*.png| png files (*.png)|*.png|jpg files (*.jpg)|*.jpg";
            if (_fileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var filePath = _fileDialog.FileName;
                    pbAvatar.Image = Image.FromFile(filePath);
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }
    }
}

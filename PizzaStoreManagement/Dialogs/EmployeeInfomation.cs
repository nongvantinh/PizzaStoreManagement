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
    public partial class EmployeeInfomation : Form
    {
        private OpenFileDialog _fileDialog = new OpenFileDialog();

        private Action _onBtnClosePressed;
        private Action _onBtnConfirmPressed;
        private string _employeeId;
        private Utils.ViewState _view;
        private Dictionary<string, Guid> _roles = new Dictionary<string, Guid>();

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public EmployeeInfomation(string header, Utils.ViewState view)
        {
            InitializeComponent();
            lbHeader.Text = header;
            _view = view;

            Utils.Database.ExecuteReader("SELECT role_id, role_name FROM pizza_store.roles;", new List<Tuple<SqlDbType, object>>(),
                reader => { while (reader.Read()) _roles.Add((string)reader["role_name"], new Guid((string)reader["role_id"])); });

            cbRole.Items.AddRange(_roles.Keys.ToArray());
            cbSex.Items.AddRange(new List<string>() { "Nam", "Nữ" }.ToArray());

        }

        public EmployeeInfomation(string header, Utils.ViewState view, string employeeId)
            : this(header, view)
        {
            _employeeId = employeeId;

            switch (_view)
            {
                case Utils.ViewState.Details:
                case Utils.ViewState.Update:
                    Utils.Database.ExecuteReader("SELECT account_username, account_password, account_avatar, account_full_name, role_name, " +
    "account_passport, account_date_of_birth, account_sex, account_phone_number, account_address FROM pizza_store.accounts " +
    " LEFT JOIN pizza_store.roles ON pizza_store.roles.role_id = pizza_store.accounts.account_role_id WHERE account_id = @account_id;",
    new List<Tuple<SqlDbType, object>>()
    {
                            new Tuple<SqlDbType, object>(SqlDbType.Char, _employeeId)
    }, reader =>
    {
        while (reader.Read())
        {
            List<object> objs = new List<object>();
            tbUsername.Texts = (string)reader["account_username"];
            tbPassword.Texts = (string)reader["account_password"];
            cpbAvatar.Image = Utils.ApplicationManager.ByteArrayToImage((byte[])reader["account_avatar"]);

            tbFullName.Texts = (string)reader["account_full_name"];
            cbRole.SelectedItem = (string)reader["role_name"];
            tbPassport.Texts = (string)reader["account_passport"];
            dtpDateOfBirth.Value = (DateTime)reader["account_date_of_birth"];
            cbSex.SelectedItem = (string)reader["account_sex"];
            tbPhoneNumber.Texts = (string)reader["account_phone_number"];
            tbAddress.Texts = (string)reader["account_address"];
        }
    });
                    break;
                case Utils.ViewState.Create:
                    break;
            }
        }

        public EmployeeInfomation(string header, Utils.ViewState view, string employeeId, Action onBtnClosePressed, Action onBtnConfirmPressed)
        : this(header, view, employeeId)
        {
            _onBtnClosePressed = onBtnClosePressed;
            _onBtnConfirmPressed = onBtnConfirmPressed;
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
                    if (0 != Utils.Database.ExecuteScalar<int>("SELECT COUNT(account_username) FROM pizza_store.accounts AS username WHERE account_username = @account_username AND account_id != @account_id;", new List<Tuple<SqlDbType, object>>()
             {
                new Tuple<SqlDbType, object>(SqlDbType.NVarChar, tbUsername.Texts),
                new Tuple<SqlDbType, object>(SqlDbType.Char, _employeeId)
             }))
                    {
                        MessageBox.Show($"{tbUsername.Texts} đã tồn tại trong cơ sở dữ liệu, hãy chọn tài khoản khác.");
                    }
                    else
                    {
                        Utils.Database.ExecuteNonQuery("UPDATE pizza_store.accounts SET account_username = @account_username, account_password = @account_password, " +
                            " account_avatar = @account_avatar, account_full_name = @account_full_name, account_role_id = @account_role_id, " +
                            " account_passport = @account_passport, account_date_of_birth = @account_date_of_birth, account_sex = @account_sex, account_phone_number = @account_phone_number, " +
                            " account_address = @account_address WHERE account_id = @account_id;", new List<Tuple<SqlDbType, object>>()
                            {
                                     new Tuple<SqlDbType, object>(SqlDbType.NChar, tbUsername.Texts),
                                     new Tuple<SqlDbType, object>(SqlDbType.NChar, tbPassword.Texts),
                                     new Tuple<SqlDbType, object>(SqlDbType.Image, Utils.ApplicationManager.ImageToByteArray(cpbAvatar.Image)),
                                     new Tuple<SqlDbType, object>(SqlDbType.NVarChar, tbFullName.Texts),
                                     new Tuple<SqlDbType, object>(SqlDbType.NChar, _roles[(string)cbRole.SelectedItem].ToString()),
                                     new Tuple<SqlDbType, object>(SqlDbType.NChar, tbPassport.Texts),
                                     new Tuple<SqlDbType, object>(SqlDbType.Date, dtpDateOfBirth.Value.Date),
                                     new Tuple<SqlDbType, object>(SqlDbType.NVarChar, cbSex.SelectedItem),
                                     new Tuple<SqlDbType, object>(SqlDbType.NChar, tbPhoneNumber.Texts),
                                     new Tuple<SqlDbType, object>(SqlDbType.NVarChar, tbAddress.Texts),

                                     new Tuple<SqlDbType, object>(SqlDbType.Char, _employeeId),
                            });
                    }
                    break;
                case Utils.ViewState.Create:
                    if (0 != Utils.Database.ExecuteScalar<int>("SELECT COUNT(account_username) FROM pizza_store.accounts AS username WHERE account_username = @account_username;", new List<Tuple<SqlDbType, object>>()
             {
                new Tuple<SqlDbType, object>(SqlDbType.NVarChar, tbUsername.Texts)
             }))
                    {
                        MessageBox.Show($"{tbUsername.Texts} đã tồn tại trong cơ sở dữ liệu, hãy chọn tài khoản khác.");
                    }
                    else
                    {
                        Utils.Database.ExecuteNonQuery("INSERT INTO pizza_store.accounts(account_id, account_username, account_password, " +
                            "account_avatar, account_full_name, account_role_id, account_passport, " +
                            "account_date_of_birth, account_sex, account_phone_number, account_address)" +
                        " VALUES(NEWID(), @account_username, @account_password, @account_avatar, @account_full_name, @account_role_id, @account_passport, " +
                        "@account_date_of_birth, @account_sex, @account_phone_number, @account_address);",
                             new List<Tuple<SqlDbType, object>>() {
                                     new Tuple<SqlDbType, object>(SqlDbType.NChar, tbUsername.Texts),
                                     new Tuple<SqlDbType, object>(SqlDbType.NChar, tbPassword.Texts),
                                     new Tuple<SqlDbType, object>(SqlDbType.Image, Utils.ApplicationManager.ImageToByteArray(cpbAvatar.Image)),
                                     new Tuple<SqlDbType, object>(SqlDbType.NVarChar, tbFullName.Texts),
                                     new Tuple<SqlDbType, object>(SqlDbType.NChar, _roles[(string)cbRole.SelectedItem].ToString()),
                                     new Tuple<SqlDbType, object>(SqlDbType.NChar, tbPassport.Texts),
                                     new Tuple<SqlDbType, object>(SqlDbType.Date, dtpDateOfBirth.Value.Date),
                                     new Tuple<SqlDbType, object>(SqlDbType.NVarChar, cbSex.SelectedItem),
                                     new Tuple<SqlDbType, object>(SqlDbType.NChar, tbPhoneNumber.Texts),
                                     new Tuple<SqlDbType, object>(SqlDbType.NVarChar, tbAddress.Texts),
                             });
                    }
                    break;
            }

            _onBtnConfirmPressed?.Invoke();
            Close();
        }

        private void lbHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void cpbAvater_Click(object sender, EventArgs e)
        {
            _fileDialog.Filter = "jpg or png files(*.jpg, *.png)|*.jpg;*.png| png files (*.png)|*.png|jpg files (*.jpg)|*.jpg";
            if (_fileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var filePath = _fileDialog.FileName;
                    cpbAvatar.Image = Image.FromFile(filePath);
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

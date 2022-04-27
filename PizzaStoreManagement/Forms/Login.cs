using System;
using System.Windows.Forms;

namespace PizzaStoreManagement.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int count = Utils.Database.ExecuteScalar<int>("SELECT COUNT(*) FROM pizza_store.accounts WHERE account_username = @account_username ",
                 new System.Collections.Generic.List<Tuple<System.Data.SqlDbType, object>>()
                 {
                    new Tuple<System.Data.SqlDbType, object>(System.Data.SqlDbType.NChar,tbUsername.Texts )
                 });

            if (0 == count)
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không được để trống!");
                return;
            }

            Utils.Database.ExecuteReader("SELECT account_id, account_username, account_password, account_avatar, account_full_name, role_name " +
                " FROM pizza_store.accounts " +
                " LEFT JOIN pizza_store.roles ON pizza_store.roles.role_id = account_role_id " +
                " WHERE account_username = @account_username;", new System.Collections.Generic.List<Tuple<System.Data.SqlDbType, object>>()
                {
                    new Tuple<System.Data.SqlDbType, object>(System.Data.SqlDbType.NChar, string.Empty == tbUsername.Texts ? Guid.NewGuid().ToString() : tbUsername.Texts)
                },
                reader =>
                {
                    while (reader.Read())
                    {
                        if (((string)reader["account_password"]).Trim() == tbPassword.Texts)
                        {
                            Home.Instance.ActivateMainScene();
                            SideMenu.Instance.Update(Utils.ApplicationManager.ByteArrayToImage((byte[])reader["account_avatar"]), (string)reader["account_id"], (string)reader["account_full_name"], (string)reader["role_name"]);
                        }
                        else
                        {
                            MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!");
                        }
                    };
                });

        }
    }
}

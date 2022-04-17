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
    public partial class ItemWithDescription : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private Action _onBtnClosePressed;
        private Action<string, string> _onBtnConfirmPressed;
        private string _itemId;

        public ItemWithDescription(string header, string title, Utils.ViewState view,string itemId, Action onBtnClosePressed, Action<string, string> onBtnConfirmPressed)
        {
            InitializeComponent();
            _onBtnClosePressed = onBtnClosePressed;
            _onBtnConfirmPressed = onBtnConfirmPressed;

            lbHeader.Text = header;
            lbTitle.Text = title;
            _itemId = itemId;

            switch (view)
            {
                case Utils.ViewState.Details:
                case Utils.ViewState.Update:
                    {
                        Utils.Database.ExecuteReader("SELECT role_name, role_description FROM pizza_store.roles WHERE role_id = @role_id;",
                            new List<Tuple<SqlDbType, object>>()
                            {
                                new Tuple<SqlDbType, object>(SqlDbType.Char, itemId )
                            },
                            (reader) =>
                            {
                                while(reader.Read())
                                {
                                    tbTitle.Texts = (string)reader["role_name"];
                                    rtbDescription.Text = (string)reader["role_description"];
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
            _onBtnConfirmPressed?.Invoke(tbTitle.Texts, rtbDescription.Text);
            Close();
        }
    }
}

using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PizzaStoreManagement.Dialogs
{
    public partial class ItemInfomation : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private Action _onBtnClosePressed;
        private Action<string> _onBtnConfirmPressed;

        public ItemInfomation(string header, string title, Utils.ViewState view, Action onBtnClosePressed, Action<string> onBtnConfirmPressed)
        {
            InitializeComponent();
            _onBtnClosePressed = onBtnClosePressed;
            _onBtnConfirmPressed = onBtnConfirmPressed;

            lbHeader.Text = header;
            lbTitle.Text = title;
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
            _onBtnConfirmPressed?.Invoke(tbValue.Texts);
            Close();
        }
    }
}

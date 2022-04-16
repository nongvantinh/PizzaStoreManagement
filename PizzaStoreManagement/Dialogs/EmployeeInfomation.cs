using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaStoreManagement.Dialogs
{
    public partial class EmployeeInfomation : Form
    {
        private OpenFileDialog fileDialog = new OpenFileDialog();


        private Action _onBtnClosePressed;
        private Action _onBtnConfirmPressed;
        private string _employeeId;
        private Ultils.ViewState _view;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        public EmployeeInfomation(string header, Ultils.ViewState view)
        {
            InitializeComponent();
            lbHeader.Text = header;
            _view = view;
        }

        public EmployeeInfomation(string header, Ultils.ViewState view, string employeeId)
            : this(header, view)
        {
            _employeeId = employeeId;
        }

        public EmployeeInfomation(string header, Ultils.ViewState view, string employeeId, Action onBtnClosePressed, Action onBtnConfirmPressed)
        : this(header, view, employeeId)
        {
            _onBtnClosePressed = onBtnClosePressed;
            _onBtnConfirmPressed = onBtnConfirmPressed;
        }

        private void btnCloseDialog_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lbHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void cpbRepresentationImage_Click(object sender, EventArgs e)
        {
            fileDialog.Filter = "jpg or png files(*.jpg, *.png)|*.jpg;*.png| png files (*.png)|*.png|jpg files (*.jpg)|*.jpg";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var filePath = fileDialog.FileName;
                    cpbRepresentationImage.Image = Image.FromFile(filePath);
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

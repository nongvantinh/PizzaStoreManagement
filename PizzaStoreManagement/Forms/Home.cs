using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PizzaStoreManagement.Forms
{
    public partial class Home : Form
    {
        public static Home Instance { get; private set; }
        private Form activeForm;

        public Home()
        {
            Instance = this;
            InitializeComponent();

            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            StartPosition = FormStartPosition.CenterScreen;

            ActiveLoginForm();
            TestScene();
        }

        private void TestScene()
        {
            OpenChildForm(new ManageStore());
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public void ActiveLoginForm()
        {
            DeactivateLoginForm();

            Forms.Login form = new Forms.Login();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            pnSideMenu.Controls.Add(form);
            pnSideMenu.Tag = form;

            form.BringToFront();
            form.Show();

            lbHeader.Text = "PIZZA STORE MANAGEMENT";

            activeForm?.Close();
        }

        private void DeactivateLoginForm()
        {
            foreach (Form form in pnSideMenu.Controls)
                form.Close();
        }

        public void ActivateMainScene()
        {
            DeactivateLoginForm();

            Forms.SideMenu form = new Forms.SideMenu();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            pnSideMenu.Controls.Add(form);
            pnSideMenu.Tag = form;

            form.BringToFront();
            form.Show();
        }

        public void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnMain.Controls.Add(childForm);
            this.pnMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lbHeader.Text = childForm.Text;
        }
    }
}

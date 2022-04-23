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
            Home.Instance.ActivateMainScene();
        }
    }
}

using System;
using System.Windows.Forms;

namespace PizzaStoreManagement.Forms
{
    public partial class SideMenu : Form
    {
        public SideMenu()
        {
            InitializeComponent();
            HideSubMenu();
        }

        private void HideSubMenu()
        {
            pnSideMenuManage.Visible = pnSideMenuManage.Visible ? false : pnSideMenuManage.Visible;
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if (!subMenu.Visible)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnSideMenuManage);
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void btnStore_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }
    }
}

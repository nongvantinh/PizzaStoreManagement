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
            Home.Instance.OpenChildForm(new ManageProduct());
            HideSubMenu();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            Home.Instance.OpenChildForm(new ManageEmployee());
        }

        private void btnStore_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void btnRole_Click(object sender, EventArgs e)
        {
            Home.Instance.OpenChildForm(new ManageRole());
            HideSubMenu();
        }

        private void btnWarehouse_Click(object sender, EventArgs e)
        {
            Home.Instance.OpenChildForm(new ManageWarehouse());
            HideSubMenu();
        }

        private void btnUnit_Click(object sender, EventArgs e)
        {
            Home.Instance.OpenChildForm(new ManageProductUnit());
            HideSubMenu();
        }

        private void btnProductKind_Click(object sender, EventArgs e)
        {
            Home.Instance.OpenChildForm(new ManageProductKind());
            HideSubMenu();
        }

        private void btnManageStore_Click(object sender, EventArgs e)
        {
            Home.Instance.OpenChildForm(new ManageStore());
            HideSubMenu();
        }
    }
}

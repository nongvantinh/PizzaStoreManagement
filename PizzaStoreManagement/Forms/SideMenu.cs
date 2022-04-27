using System;
using System.Drawing;
using System.Windows.Forms;

namespace PizzaStoreManagement.Forms
{
    public partial class SideMenu : Form
    {
        public static SideMenu Instance { get; set; }
        public string AccountId = string.Empty;
        public string AccountFullName = string.Empty;
        public string AccountRole = string.Empty;

        public SideMenu()
        {
            Instance = this;

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
            Home.Instance.OpenChildForm(new Statistics());
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

        internal void Update(Image avatar, string v1, string v2, string v3)
        {
            cpbAvatar.Image = avatar;
            AccountId = v1;
            AccountFullName = v2;
            AccountRole = v3;

            label4.Text = v2;
            label5.Text = v3;
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

        public void btnManageStore_Click(object sender, EventArgs e)
        {
            Home.Instance.OpenChildForm(new ManageStore());
            HideSubMenu();
        }

        private void btnPromotion_Click(object sender, EventArgs e)
        {
            Home.Instance.OpenChildForm(new ManagePromotion());
            HideSubMenu();
        }

        private void btnVoucher_Click(object sender, EventArgs e)
        {
            Home.Instance.OpenChildForm(new ManageVoucher());
            HideSubMenu();
        }
    }
}

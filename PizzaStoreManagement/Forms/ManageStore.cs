using PizzaStoreManagement.Controls;
using System;
using System.Windows.Forms;

namespace PizzaStoreManagement.Forms
{
    public partial class ManageStore : Form
    {
        int _tableIndex = 0;
        private Random _random = new Random();
        public ManageStore()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            var table = new Controls.DinnerTable(++_tableIndex, _random.Next(0, DinnerTable.MaxPerson));
            table.Dock = DockStyle.Left;
            table.OnClickOnTable += (tableIndex, numPerson) => { MessageBox.Show($"{tableIndex}, {numPerson}"); };
            panel2.Controls.Add(table);
            panel2.Controls.SetChildIndex(table, 1);
        }
    }
}

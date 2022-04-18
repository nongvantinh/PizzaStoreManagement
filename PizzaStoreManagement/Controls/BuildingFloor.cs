using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaStoreManagement.Controls
{
    public partial class BuildingFloor : UserControl
    {
        public int FloorIndex;
        public event Action<int> OnClickOnTable;

        public BuildingFloor()
        {
            InitializeComponent();
        }

        public BuildingFloor(int floorIndex):this()
        {
            FloorIndex = floorIndex;
        }

        private void pbFloor_Click(object sender, EventArgs e)
        {
            OnClickOnTable?.Invoke(FloorIndex);
        }
    }
}

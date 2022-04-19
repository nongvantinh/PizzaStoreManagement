using System;
using System.Windows.Forms;

namespace PizzaStoreManagement.Controls
{
    public partial class BuildingFloor : UserControl
    {
        public int FloorIndex;
        public event Action<int> OnClickOnFloor;

        public BuildingFloor()
        {
            InitializeComponent();
        }

        public BuildingFloor(int floorIndex):this()
        {
            FloorIndex = floorIndex;
            label.Text = "Tầng " + floorIndex.ToString();
        }

        private void pbFloor_Click(object sender, EventArgs e)
        {
            OnClickOnFloor?.Invoke(FloorIndex);
        }
    }
}

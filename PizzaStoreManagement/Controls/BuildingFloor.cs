using System;
using System.Windows.Forms;

namespace PizzaStoreManagement.Controls
{
    public partial class BuildingFloor : UserControl
    {
        public string FloorId;
        public string FloorDescription;
        public event Action<MouseButtons, string, string> OnClickOnFloor;

        public BuildingFloor()
        {
            InitializeComponent();
        }

        public BuildingFloor(string floorId, string floorName) : this()
        {
            FloorId = floorId;
            label.Text = FloorDescription = floorName;
        }

        private void pbFloor_MouseClick(object sender, MouseEventArgs e)
        {
            OnClickOnFloor?.Invoke(e.Button, FloorId, FloorDescription);
        }
    }
}

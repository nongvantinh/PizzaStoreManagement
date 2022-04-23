using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PizzaStoreManagement.Controls
{
    public partial class DinnerTable : UserControl
    {
        public string AtFloorId;
        public string TableId;
        public string TableDescription;

        public const int MaxPerson = 8;

        public event Action<MouseButtons, string, string, string, int> OnClickOnTable;


        private int _numPerson = 0;
        public int NumPerson
        {
            get => _numPerson; set
            {
                _numPerson = value;
                for (int i = 0; i != _numPerson; ++i) persons[i].Show();

                for (int i = value; i != _numPerson; ++i) persons[i].Hide();
            }
        }

        private List<PictureBox> persons;

        public DinnerTable()
        {
            InitializeComponent();
            persons = new List<PictureBox>() { pbPerson1, pbPerson5, pbPerson7, pbPerson3, pbPerson8, pbPerson2, pbPerson4, pbPerson6, };
            persons.ForEach(x => x.Hide());
            RotatePerson();
        }
        public DinnerTable(string tableId, string tableDescription, string atFloorId) : this()
        {
            TableId = tableId;
            label.Text = TableDescription = tableDescription;
            AtFloorId = atFloorId;
            NumPerson = 0;
        }

        public DinnerTable(string tableId, string tableDescription, string atFloorId, int numPerson) : this(tableId, tableDescription, atFloorId)
        {
            NumPerson = numPerson;
        }

        private void RotatePerson()
        {
            float angle = 0;
            pbPerson2.Image = Utils.ApplicationManager.RotateImage(pbPerson2.Image, angle += 45);
            pbPerson3.Image = Utils.ApplicationManager.RotateImage(pbPerson3.Image, angle += 45);
            pbPerson4.Image = Utils.ApplicationManager.RotateImage(pbPerson4.Image, angle += 45);
            pbPerson5.Image = Utils.ApplicationManager.RotateImage(pbPerson5.Image, angle += 45);
            pbPerson6.Image = Utils.ApplicationManager.RotateImage(pbPerson6.Image, angle += 45);
            pbPerson7.Image = Utils.ApplicationManager.RotateImage(pbPerson7.Image, angle += 45);
            pbPerson8.Image = Utils.ApplicationManager.RotateImage(pbPerson8.Image, angle += 45);
        }

        private void label_MouseClick(object sender, MouseEventArgs e)
        {
            OnClickOnTable?.Invoke(e.Button, TableId, TableDescription, AtFloorId, NumPerson);
        }

        private void pictureBox18_MouseClick(object sender, MouseEventArgs e)
        {
            OnClickOnTable?.Invoke(e.Button, TableId, TableDescription, AtFloorId, NumPerson);
        }
    }
}

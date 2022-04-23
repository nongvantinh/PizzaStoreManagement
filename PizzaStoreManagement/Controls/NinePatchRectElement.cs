using System;
using System.Windows.Forms;

namespace PizzaStoreManagement.Controls
{
    public partial class NinePatchRectElement : UserControl
    {
        private string _id;
        private byte[] _avatar;
        private string _name;
        private int _price;
        private string _kind;
        private string _unit;


        public string Id { get { return _id; } set { _id = value; } }
        public byte[] Avatar { get { return _avatar; } set { _avatar = value; } }
        public string ItemName { get { return _name; } set { _name = value; } }
        public int Price
        {
            get { return _price; }
            set
            {
                _price = value;
                lbPrice.Text = value.ToString();
            }
        }
        public string Kind { get { return _kind; } set { _kind = value; } }
        public string Unit { get { return _unit; } set { _unit = value; } }

        public event Action<MouseButtons, string, byte[], string, int, string, string> OnClickOnProduct;

        public NinePatchRectElement()
        {
            InitializeComponent();
        }

        public NinePatchRectElement(string id, byte[] avatar, string name, int price, string kind, string unit)
            : this()
        {
            this._id = id;
            this._avatar = avatar;
            this._name = name;
            this._price = price;
            this._kind = kind;
            this._unit = unit;

            lbPrice.Text = price.ToString();
            pbAvatar.Image = Utils.ApplicationManager.ByteArrayToImage(avatar);
            tbName.Text = name;
        }

        private void pbAvatar_MouseClick(object sender, MouseEventArgs e)
        {
            OnClickOnProduct?.Invoke(e.Button, _id, _avatar, _name, _price, _kind, _unit);
        }

        private void tbName_MouseClick(object sender, MouseEventArgs e)
        {
            OnClickOnProduct?.Invoke(e.Button, _id, _avatar, _name, _price, _kind, _unit);
        }
    }
}

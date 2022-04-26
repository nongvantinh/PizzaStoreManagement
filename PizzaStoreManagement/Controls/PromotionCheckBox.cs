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
    public partial class PromotionCheckBox : UserControl
    {
        public string Id { get; set; }
        public string Content { get; set; }
        public string Kind { get; set; }
        public string TheName { get; set; }
        public int PercentDiscount { get; set; }
        public int CashDiscount { get; set; }
        public int MaxDiscount { get; set; }
        public int Condition { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool Incremental { get; set; }

        private Action<bool, string, string, int, int, int, int, bool> _onPressed;

        public PromotionCheckBox()
        {
            InitializeComponent();
        }

        public PromotionCheckBox(string id, string content, string kind, string name, int percentDiscount, 
            int cashDiscount, int maxDiscount, int condition, DateTime startDate, DateTime endDate, bool incremental, Action<bool, string, string, int, int, int, int, bool> onPressed) : this()
        {
            Id = id;
            Content = content;
            Kind = kind;
            Name = name;
            PercentDiscount = percentDiscount;
            CashDiscount = cashDiscount;
            MaxDiscount = maxDiscount;
            Condition = condition;
            StartDate = startDate;
            EndDate = endDate;
            Incremental = incremental;

            _onPressed = onPressed;
            checkBox1.Text = content;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            _onPressed?.Invoke(checkBox1.Checked, Kind, Name, PercentDiscount, CashDiscount, MaxDiscount, Condition, Incremental);
        }
    }
}

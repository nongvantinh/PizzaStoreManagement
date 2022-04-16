using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaStoreManagement.Dialogs
{
    public partial class EmployeeInfomation : Form
    {
        private Action _onBtnClosePressed;
        private Action _onBtnConfirmPressed;
        private string _employeeId;
        private Ultils.ViewState _view;

        public EmployeeInfomation(string header, Ultils.ViewState view)
        {
            InitializeComponent();
            lbHeader.Text = header;
            _view = view;
        }

        public EmployeeInfomation(string header, Ultils.ViewState view, string employeeId)
            : this(header, view)
        {
            _employeeId = employeeId;
        }

        public EmployeeInfomation(string header, Ultils.ViewState view, string employeeId, Action onBtnClosePressed, Action onBtnConfirmPressed)
        : this(header, view, employeeId)
        {
            _onBtnClosePressed = onBtnClosePressed;
            _onBtnConfirmPressed = onBtnConfirmPressed;
        }
    }
}

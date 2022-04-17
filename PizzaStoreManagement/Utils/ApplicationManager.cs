using System.Drawing;
using System.Windows.Forms;

namespace PizzaStoreManagement.Utils
{
    public static class ApplicationManager
    {
        public static void SetTextBoxStyle(TextBoxBase tb, bool readOnly)
        {
            tb.ReadOnly = readOnly;
            if (readOnly)
            {
                tb.BackColor = Color.FromArgb(127, 143, 166);
                tb.BorderStyle = BorderStyle.None;
            }
            else
            {
                tb.BackColor = Color.FromName("Window");
                tb.BorderStyle = BorderStyle.Fixed3D;
            }
        }

        public static void ShowDialog(Form dialog)
        {
            dialog.StartPosition = FormStartPosition.CenterScreen;
            dialog.FormBorderStyle = FormBorderStyle.None;
            dialog.ShowDialog();
        }
    }
}

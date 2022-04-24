using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace PizzaStoreManagement.Forms
{
    public partial class ManagePromotion : Form
    {
        private int currentMouseOverRow = 0;
        private int currentMouseOverColumn = 0;

        public ManagePromotion()
        {
            InitializeComponent();
            RefreshDataGridView();
        }
        private void RefreshDataGridView()
        {
            dataGridView1.Rows.Clear();
            Utils.Database.ExecuteReader("SELECT promotion_id, promotion_content," +
                " promotion_percent_discount, promotion_cash_discount, promotion_max_discount," +
                " promotion_condition FROM pizza_store.promotions ORDER BY promotion_end_date DESC;", new List<Tuple<SqlDbType, object>>(),
    reader =>
    {
        for (int i = 0; reader.Read(); ++i)
        {
            List<object> objs = new List<object>();
            objs.Add(reader["promotion_id"]);
            objs.Add(reader["promotion_content"]);
            objs.Add(reader["promotion_percent_discount"]);
            objs.Add(reader["promotion_cash_discount"]);
            objs.Add(reader["promotion_max_discount"]);
            objs.Add(reader["promotion_condition"]);
            
            dataGridView1.Rows.Add(objs.ToArray());
        }
    });

        }

        private void ManagePromotion_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                currentMouseOverRow = dataGridView1.HitTest(e.X, e.Y).RowIndex;
                currentMouseOverColumn = dataGridView1.HitTest(e.X, e.Y).ColumnIndex;

                ContextMenuStrip m = new ContextMenuStrip();

                m.Items.Add("Thêm mới").Click += AddNew;
                if (-1 != currentMouseOverRow || -1 != currentMouseOverColumn)
                {
                    m.Items.Add("Cập Nhật").Click += Update;
                    m.Items.Add("Xóa").Click += Delete;
                }

                m.Show(new Point(Cursor.Position.X, Cursor.Position.Y));
            }
        }

        private void AddNew(object sender, EventArgs e)
        {
            var dialog = new Dialogs.Promotion(String.Empty, Utils.ViewState.Create, () => { }, () =>
            {
                RefreshDataGridView();

            });
            Utils.ApplicationManager.ShowDialog(dialog);
        }

        private void Update(object sender, EventArgs e)
        {
            var dialog = new Dialogs.Promotion((string)dataGridView1.Rows[currentMouseOverRow].Cells[0].Value, Utils.ViewState.Update, () => { }, () =>
            {
                RefreshDataGridView();

            });
            Utils.ApplicationManager.ShowDialog(dialog);
        }

        private void Delete(object sender, EventArgs e)
        {
            Utils.Database.ExecuteNonQuery("DELETE FROM pizza_store.promotions WHERE promotion_id = @promotion_id;", new List<Tuple<SqlDbType, object>>()
            {
                new Tuple<SqlDbType, object>(SqlDbType.Char, (string)dataGridView1.Rows[currentMouseOverRow].Cells[0].Value)
            });
                RefreshDataGridView();
        }

    }
}

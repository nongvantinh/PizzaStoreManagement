using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace PizzaStoreManagement.Forms
{
    public partial class ManageVoucher : Form
    {
        private int currentMouseOverRow = 0;
        private int currentMouseOverColumn = 0;

        public ManageVoucher()
        {
            InitializeComponent();
            RefreshDataGridView();
        }
        private void RefreshDataGridView()
        {
            dataGridView1.Rows.Clear();
            Utils.Database.ExecuteReader("SELECT voucher_id, voucher_code, voucher_content, voucher_kind, " +
                " voucher_product_id, voucher_percent_discount, voucher_cash_discount, " +
                " voucher_max_discount, voucher_condition, voucher_number_of_uses, " +
                " voucher_expiry, voucher_incremental FROM pizza_store.vouchers ORDER BY voucher_expiry DESC;", new List<Tuple<SqlDbType, object>>(),
    reader =>
    {
        for (int i = 0; reader.Read(); ++i)
        {
            List<object> objs = new List<object>();
            objs.Add(reader["voucher_id"]);
            objs.Add(reader["voucher_code"]);
            objs.Add(reader["voucher_content"]);
            objs.Add(reader["voucher_percent_discount"]);
            objs.Add(reader["voucher_cash_discount"]);
            objs.Add(((DateTime)reader["voucher_expiry"]).Date.ToString("yyyy/MM/dd"));
            objs.Add(reader["voucher_number_of_uses"]);

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
            var dialog = new Dialogs.Voucher(String.Empty, Utils.ViewState.Create, () => { }, () =>
            {
                RefreshDataGridView();

            });
            Utils.ApplicationManager.ShowDialog(dialog);
        }

        private void Update(object sender, EventArgs e)
        {
            var dialog = new Dialogs.Voucher((string)dataGridView1.Rows[currentMouseOverRow].Cells[0].Value, Utils.ViewState.Update, () => { }, () =>
            {
                RefreshDataGridView();

            });
            Utils.ApplicationManager.ShowDialog(dialog);
        }

        private void Delete(object sender, EventArgs e)
        {
            Utils.Database.ExecuteNonQuery("DELETE FROM pizza_store.vouchers WHERE voucher_id = @voucher_id;", new List<Tuple<SqlDbType, object>>()
            {
                new Tuple<SqlDbType, object>(SqlDbType.Char, (string)dataGridView1.Rows[currentMouseOverRow].Cells[0].Value)
            });
            RefreshDataGridView();
        }

    }
}

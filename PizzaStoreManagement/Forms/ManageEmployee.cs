using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace PizzaStoreManagement.Forms
{
    public partial class ManageEmployee : Form
    {
        int currentMouseOverRow = 0;
        int currentMouseOverColumn = 0;

        public ManageEmployee()
        {
            InitializeComponent();
            InitGridView();
            RefreshDataGridView();

        }

        private void InitGridView()
        {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            for (int k = 0; k != dataGridView1.Columns.Count; ++k)
            {
                dataGridView1.Columns[k].ReadOnly = true;
            }
        }

        private void RefreshDataGridView()
        {
            dataGridView1.Rows.Clear();
            Utils.Database.ExecuteReader("SELECT account_id, account_full_name, role_name, account_date_of_birth, account_phone_number FROM pizza_store.accounts " +
                " LEFT JOIN pizza_store.roles ON pizza_store.roles.role_id = account_role_id;", new List<Tuple<SqlDbType, object>>(),
                reader =>
                {
                    for (int i = 0; reader.Read(); ++i)
                    {
                        List<object> objs = new List<object>();
                        objs.Add(reader["account_id"]);
                        objs.Add(reader["account_full_name"]);
                        objs.Add(reader["role_name"]);
                        objs.Add(((DateTime)reader["account_date_of_birth"]).ToString("yyyy-M-dd"));
                        objs.Add(reader["account_phone_number"]);

                        dataGridView1.Rows.Add(objs.ToArray());
                    }
                });
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
                       if (e.Button == MouseButtons.Right)
            {
                currentMouseOverRow = dataGridView1.HitTest(e.X, e.Y).RowIndex;
                currentMouseOverColumn = dataGridView1.HitTest(e.X, e.Y).ColumnIndex;

                ContextMenuStrip m = new ContextMenuStrip();

                m.Items.Add("Thêm mới").Click += AddNew;
                if (-1 != currentMouseOverRow || -1 != currentMouseOverColumn)
                {
                    m.Items.Add("Chi tiết").Click += Details;
                    m.Items.Add("Cập Nhật").Click += Update;
                    m.Items.Add("Xóa").Click += Delete;
                }

                m.Show(new Point(Cursor.Position.X, Cursor.Position.Y));
            }
        }

        private void AddNew(object sender, EventArgs e)
        {
            var dialog = new Dialogs.EmployeeInfomation("Thông Tin Nhân Viên", Utils.ViewState.Create, string.Empty, () => { }, () => { RefreshDataGridView(); });
            Utils.ApplicationManager.ShowDialog(dialog);
        }

        private void Update(object sender, EventArgs e)
        {
            var dialog = new Dialogs.EmployeeInfomation("Thông Tin Nhân Viên", Utils.ViewState.Update, (string)dataGridView1.Rows[currentMouseOverRow].Cells[0].Value, () => { }, () => { RefreshDataGridView(); });
            Utils.ApplicationManager.ShowDialog(dialog);
        }

        private void Details(object sender, EventArgs e)
        {
            var dialog = new Dialogs.EmployeeInfomation("Thông Tin Nhân Viên", Utils.ViewState.Details, (string)dataGridView1.Rows[currentMouseOverRow].Cells[0].Value);
            Utils.ApplicationManager.ShowDialog(dialog);
        }

        private void Delete(object sender, EventArgs e)
        {
            Utils.Database.ExecuteNonQuery("DELETE FROM pizza_store.accounts WHERE account_id = @account_id;", new List<Tuple<SqlDbType, object>>()
            {
                new Tuple<SqlDbType, object>(SqlDbType.Char, dataGridView1.Rows[currentMouseOverRow].Cells[0].Value)
            });
            RefreshDataGridView();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var dialog = new Dialogs.EmployeeInfomation("Thêm Nhân Viên", Utils.ViewState.Create);
            dialog.StartPosition = FormStartPosition.CenterScreen;
            dialog.ShowDialog();
        }
    }
}

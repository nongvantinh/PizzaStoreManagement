using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace PizzaStoreManagement.Forms
{
    public partial class ManageRole : Form
    {
        int currentMouseOverRow = 0;
        int currentMouseOverColumn = 0;

        public ManageRole()
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
            Utils.Database.ExecuteReader("SELECT role_id, role_name, role_description" +
                " FROM pizza_store.roles;", new List<Tuple<SqlDbType, object>>(),
                reader =>
                {
                    for (int i = 0; reader.Read(); ++i)
                    {
                        List<object> objs = new List<object>();
                        objs.Add(reader["role_id"]);
                        objs.Add(reader["role_name"]);
                        objs.Add(reader["role_description"]);

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
                    m.Items.Add("Cập Nhật").Click += Update;
                    m.Items.Add("Xóa").Click += Delete;
                }

                m.Show(new Point(Cursor.Position.X, Cursor.Position.Y));
            }
        }

        private void AddNew(object sender, EventArgs e)
        {
            var dialog = new Dialogs.ItemWithDescription("Thêm Chức Vụ Mới", "Tên Chức Vụ", Utils.ViewState.Create, string.Empty, () => { }, (title, description) =>
             {
                 if (0 != Utils.Database.ExecuteScalar<int>("SELECT COUNT(role_name) FROM pizza_store.roles AS role WHERE role_name = @role_name;", new List<Tuple<SqlDbType, object>>()
             {
                new Tuple<SqlDbType, object>(SqlDbType.NVarChar, title)
             }))
                 {
                     MessageBox.Show($"{title} đã tồn tại trong cơ sở dữ liệu, hãy chọn tên khác.");
                 }
                 else
                 {
                     Utils.Database.ExecuteNonQuery("INSERT INTO pizza_store.roles(role_id, role_name, role_description)" +
                     " VALUES(NEWID(), @role_name, @role_description);",
                          new List<Tuple<SqlDbType, object>>() {
                                     new Tuple<SqlDbType, object>(SqlDbType.NVarChar, title),
                                     new Tuple<SqlDbType, object>(SqlDbType.NVarChar, description),
                          });
                 }
                 RefreshDataGridView();
             });

            Utils.ApplicationManager.ShowDialog(dialog);
        }

        private void Update(object sender, EventArgs e)
        {
            var dialog = new Dialogs.ItemWithDescription("Chỉnh Sửa Tông Tin", "Tên Chức Vụ", Utils.ViewState.Update, (string)dataGridView1.Rows[currentMouseOverRow].Cells[0].Value, () => { }, (title, description) =>
            {
                if (title != (string)dataGridView1.Rows[currentMouseOverRow].Cells[currentMouseOverColumn].Value)
                    if (0 != Utils.Database.ExecuteScalar<int>("SELECT COUNT(role_name) FROM pizza_store.roles AS role WHERE role_name = @role_name;", new List<Tuple<SqlDbType, object>>()
            {
                new Tuple<SqlDbType, object>(SqlDbType.NVarChar, title)
            }))
                    {
                        MessageBox.Show($"Cập nhật thất bại. {title} đã tồn tại trong cơ sở dữ liệu, hãy chọn tên khác.");
                        return;
                    }

                {
                    Utils.Database.ExecuteNonQuery("UPDATE pizza_store.roles SET role_name = @role_name, role_description = @role_description WHERE role_id = @role_id;",
                         new List<Tuple<SqlDbType, object>>() {
                                     new Tuple<SqlDbType, object>(SqlDbType.NVarChar, title),
                                     new Tuple<SqlDbType, object>(SqlDbType.NVarChar,description),
                                     new Tuple<SqlDbType, object>(SqlDbType.Char,dataGridView1.Rows[currentMouseOverRow].Cells[0].Value),
                         });
                }
                RefreshDataGridView();
            });

            Utils.ApplicationManager.ShowDialog(dialog);
        }

        private void Delete(object sender, EventArgs e)
        {
            Utils.Database.ExecuteNonQuery("DELETE FROM pizza_store.roles WHERE role_id = @role_id;", new List<Tuple<SqlDbType, object>>()
            {
                new Tuple<SqlDbType, object>(SqlDbType.Char, dataGridView1.Rows[currentMouseOverRow].Cells[0].Value)
            });
            RefreshDataGridView();
        }
    }
}

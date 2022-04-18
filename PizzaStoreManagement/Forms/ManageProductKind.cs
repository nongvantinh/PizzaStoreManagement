using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace PizzaStoreManagement.Forms
{
    public partial class ManageProductKind : Form
    {
        private int currentMouseOverRow = 0;
        private int currentMouseOverColumn = 0;

        public ManageProductKind()
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
            Utils.Database.ExecuteReader("SELECT kind_id, kind_name FROM pizza_store.product_kind;", new List<Tuple<SqlDbType, object>>(),
                reader =>
                {
                    for (int i = 0; reader.Read(); ++i)
                    {
                        List<object> objs = new List<object>();
                        objs.Add(reader["kind_id"]);
                        objs.Add(reader["kind_name"]);

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
            var dialog = new Dialogs.ItemInfomation("Thêm Loại Sản Phẩm", "Tên loại sản phẩm", Utils.ViewState.Create, () => { }, (value) =>
            {
                if (0 != Utils.Database.ExecuteScalar<int>("SELECT COUNT(kind_name) FROM pizza_store.product_kind AS name WHERE kind_name = @kind_name;", new List<Tuple<SqlDbType, object>>()
             {
                new Tuple<SqlDbType, object>(SqlDbType.NVarChar, value),
             }))
                {
                    MessageBox.Show($"{value} đã tồn tại trong cơ sở dữ liệu, hãy chọn một tên khác.");
                }
                else
                {
                    Utils.Database.ExecuteNonQuery("INSERT INTO pizza_store.product_kind(kind_id, kind_name) VALUES(NEWID(), @kind_name);", new List<Tuple<SqlDbType, object>>()
                    {
                        new Tuple<SqlDbType, object>(SqlDbType.NVarChar, value)
                    });
                    RefreshDataGridView();
                }
            });
            Utils.ApplicationManager.ShowDialog(dialog);
        }

        private void Update(object sender, EventArgs e)
        {
            var dialog = new Dialogs.ItemInfomation("Chỉnh Sửa Loại Sản Phẩm", "Tên loại sản phẩm", Utils.ViewState.Update, () => { }, (value) =>
            {
                if (0 != Utils.Database.ExecuteScalar<int>("SELECT COUNT(kind_name) FROM pizza_store.product_kind AS name WHERE kind_name = @kind_name AND kind_id != @kind_id;", new List<Tuple<SqlDbType, object>>()
            {
                new Tuple<SqlDbType, object>(SqlDbType.NVarChar, value),
                new Tuple<SqlDbType, object>(SqlDbType.Char, (string)dataGridView1.Rows[currentMouseOverRow].Cells[0].Value),
            }))
                {
                    MessageBox.Show($"Cập nhật thất bại. {value} đã tồn tại trong cơ sở dữ liệu, hãy chọn tên khác.");
                    return;
                }

                {
                    Utils.Database.ExecuteNonQuery("UPDATE pizza_store.product_kind SET kind_name = @kind_name WHERE kind_id = @kind_id;",
                         new List<Tuple<SqlDbType, object>>() {
                                     new Tuple<SqlDbType, object>(SqlDbType.NVarChar, value),
                                     new Tuple<SqlDbType, object>(SqlDbType.Char,dataGridView1.Rows[currentMouseOverRow].Cells[0].Value),
                         });
                }
                RefreshDataGridView();
            });

            Utils.ApplicationManager.ShowDialog(dialog);
        }

        private void Delete(object sender, EventArgs e)
        {
            Utils.Database.ExecuteNonQuery("DELETE FROM pizza_store.product_kind WHERE kind_id = @kind_id;", new List<Tuple<SqlDbType, object>>()
            {
                new Tuple<SqlDbType, object>(SqlDbType.Char, dataGridView1.Rows[currentMouseOverRow].Cells[0].Value)
            });
            RefreshDataGridView();
        }
    }
}

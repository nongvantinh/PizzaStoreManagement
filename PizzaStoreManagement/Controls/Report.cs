using Microsoft.Reporting.WinForms;
using System;
using System.Collections;
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
    public partial class Report : Form
    {
        private string _orderId;
        private string _promotionId;
        private string _voucherId;

        public Report(string orderId, string promotionId, string voucherId)
        {
            _orderId = orderId;
            _promotionId = promotionId;
            _voucherId = voucherId;

            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            try
            {
                reportViewer1.LocalReport.ReportEmbeddedResource = "PizzaStoreManagement.Payment.rdlc";
                ReportDataSource reportDataSource = new ReportDataSource();
                reportDataSource.Name = "DataSet1";

                Utils.Database.ExecuteReader("EXEC payment @id, @p_id, @v_id; ", new List<Tuple<SqlDbType, object>>()
                {
                    new Tuple<SqlDbType, object>(SqlDbType.Char, _orderId),
                    new Tuple<SqlDbType, object>(SqlDbType.Char, _promotionId),
                    new Tuple<SqlDbType, object>(SqlDbType.Char, _voucherId),
                }, reader =>
                {
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    reportDataSource.Value = RemoveDuplicateRows(dataTable, "product_name");
                });

                reportViewer1.LocalReport.DataSources.Add(reportDataSource);

                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        public DataTable RemoveDuplicateRows(DataTable dTable, string colName)
        {
            Hashtable hTable = new Hashtable();
            ArrayList duplicateList = new ArrayList();

            //Add list of all the unique item value to hashtable, which stores combination of key, value pair.
            //And add duplicate item value in arraylist.
            foreach (DataRow drow in dTable.Rows)
            {
                if (hTable.Contains(drow[colName]))
                    duplicateList.Add(drow);
                else
                    hTable.Add(drow[colName], string.Empty);
            }

            //Removing a list of duplicate items from datatable.
            foreach (DataRow dRow in duplicateList)
                dTable.Rows.Remove(dRow);

            //Datatable which contains unique records will be return as output.
            return dTable;
        }

    }
}

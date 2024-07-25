using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRSqlLiteWin19.MyClasses; 

namespace QRSqlLiteWin19
{
    public partial class FormQRCodeSearch : Form
    {
        DatabaseHelper DatabaseHelperObj;
        QRData QRDataMainObj;
        public FormQRCodeSearch()
        {
            InitializeComponent();

            DatabaseHelperObj = new DatabaseHelper();
            QRDataMainObj = new QRData();
            dataGridViewQRData.AutoGenerateColumns = false;

            dgcDataColumn1.HeaderText = Properties.Settings.Default.ColumnName1 != "" ? Properties.Settings.Default.ColumnName1 : dgcDataColumn1.HeaderText;
            dgcDataColumn2.HeaderText = Properties.Settings.Default.ColumnName2 != "" ? Properties.Settings.Default.ColumnName2 : dgcDataColumn2.HeaderText;
            dgcDataColumn3.HeaderText = Properties.Settings.Default.ColumnName3 != "" ? Properties.Settings.Default.ColumnName3 : dgcDataColumn3.HeaderText;
            dgcDataColumn4.HeaderText = Properties.Settings.Default.ColumnName4 != "" ? Properties.Settings.Default.ColumnName4 : dgcDataColumn4.HeaderText;
            dgcDataColumn5.HeaderText = Properties.Settings.Default.ColumnName5 != "" ? Properties.Settings.Default.ColumnName5 : dgcDataColumn5.HeaderText;
            dgcDataColumn6.HeaderText = Properties.Settings.Default.ColumnName6 != "" ? Properties.Settings.Default.ColumnName6 : dgcDataColumn6.HeaderText;
            dgcDataColumn7.HeaderText = Properties.Settings.Default.ColumnName7 != "" ? Properties.Settings.Default.ColumnName7 : dgcDataColumn7.HeaderText;
            dgcDataColumn8.HeaderText = Properties.Settings.Default.ColumnName8 != "" ? Properties.Settings.Default.ColumnName8 : dgcDataColumn8.HeaderText;
            dgcDataColumn9.HeaderText = Properties.Settings.Default.ColumnName9 != "" ? Properties.Settings.Default.ColumnName9 : dgcDataColumn9.HeaderText;
            dgcDataColumn10.HeaderText = Properties.Settings.Default.ColumnName10 != "" ? Properties.Settings.Default.ColumnName10 : dgcDataColumn10.HeaderText;
        }

        private void ShowQRData()
        {
            dataGridViewQRData.DataSource = DatabaseHelperObj.Read();
        }

        private void FormQRCodeSearch_Load(object sender, EventArgs e)
        {
            ShowQRData();
        }
       
        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            FormQRCodeSingle frmObj = new FormQRCodeSingle(new QRData());
            frmObj.ShowDialog();
            if (frmObj.DialogResult == DialogResult.OK)
                ShowQRData();
        }

        private void EditQRData()
        {
            FormQRCodeSingle frmObj = new FormQRCodeSingle(DatabaseHelperObj.Read(Convert.ToInt32(dataGridViewQRData.CurrentRow.Cells[0].Value.ToString())));
            frmObj.ShowDialog();
            if (frmObj.DialogResult == DialogResult.OK)
                ShowQRData();
        }
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            EditQRData();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete selected record?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (DatabaseHelperObj.Delete(Convert.ToInt64(dataGridViewQRData.CurrentRow.Cells[0].Value.ToString())))
                {
                    //MessageBox.Show("Record Deleted!");
                    ShowQRData();
                }
            }
        }

        private void dataGridViewQRData_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            EditQRData();
        }

        private void buttonQRReport_Click(object sender, EventArgs e)
        {
            FormReportViewer FormReportViewerObj = new FormReportViewer((List<QRData>)dataGridViewQRData.DataSource);
            FormReportViewerObj.ShowDialog();
        }

        private void dataGridViewQRData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex==dgcPrintQR.Index)
            {
                long QRDataId = Convert.ToInt64(dataGridViewQRData.CurrentRow.Cells[dgcQRDataId.Name].Value.ToString());
                List<QRData> selectedItems = ((List<QRData>)dataGridViewQRData.DataSource).Where(Item => Item.QRDataId == QRDataId).ToList();
                FormReportViewer FormReportViewerObj = new FormReportViewer(selectedItems);
                FormReportViewerObj.ShowDialog();
            }
        }
    }
}

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
    public partial class FormQRCodeSingle : Form
    {
        private DatabaseHelper DatabaseHelperObj;
        private QRData QRDataMainObj;
        public FormQRCodeSingle(QRData QRDataMainObj)
        {
            InitializeComponent();

            DatabaseHelperObj = new DatabaseHelper();
            this.QRDataMainObj = QRDataMainObj;

            labelColumnName1.Text = Properties.Settings.Default.ColumnName1 != "" ? Properties.Settings.Default.ColumnName1 : labelColumnName1.Text;
            labelColumnName2.Text = Properties.Settings.Default.ColumnName2 != "" ? Properties.Settings.Default.ColumnName2 : labelColumnName2.Text;
            labelColumnName3.Text = Properties.Settings.Default.ColumnName3 != "" ? Properties.Settings.Default.ColumnName3 : labelColumnName3.Text;
            labelColumnName4.Text = Properties.Settings.Default.ColumnName4 != "" ? Properties.Settings.Default.ColumnName4 : labelColumnName4.Text;
            labelColumnName5.Text = Properties.Settings.Default.ColumnName5 != "" ? Properties.Settings.Default.ColumnName5 : labelColumnName5.Text;
            labelColumnName6.Text = Properties.Settings.Default.ColumnName6 != "" ? Properties.Settings.Default.ColumnName6 : labelColumnName6.Text;
            labelColumnName7.Text = Properties.Settings.Default.ColumnName7 != "" ? Properties.Settings.Default.ColumnName7 : labelColumnName7.Text;
            labelColumnName8.Text = Properties.Settings.Default.ColumnName8 != "" ? Properties.Settings.Default.ColumnName8 : labelColumnName8.Text;
            labelColumnName9.Text = Properties.Settings.Default.ColumnName9 != "" ? Properties.Settings.Default.ColumnName9 : labelColumnName9.Text;
            labelColumnName10.Text = Properties.Settings.Default.ColumnName10 != "" ? Properties.Settings.Default.ColumnName10 : labelColumnName10.Text;
        }

        private void FormQRCodeSingle_Load(object sender, EventArgs e)
        {
            if (QRDataMainObj.QRDataId != 0)
            {
                dtpQRDate.Value = QRDataMainObj.QRDate;
                textColumnData1.Text = QRDataMainObj.DataColumn1;
                textColumnData2.Text = QRDataMainObj.DataColumn2;
                textColumnData3.Text = QRDataMainObj.DataColumn3;
                textColumnData4.Text = QRDataMainObj.DataColumn4;
                textColumnData5.Text = QRDataMainObj.DataColumn5;
                dtpRefilledDate.Value = QRDataMainObj.DataColumn6;
                dtpRefillDueDate.Value = QRDataMainObj.DataColumn7;
                textColumnData8.Text = QRDataMainObj.DataColumn8;
                textColumnData9.Text = QRDataMainObj.DataColumn9;
                textColumnData10.Text = QRDataMainObj.DataColumn10;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                QRDataMainObj.QRDate = dtpQRDate.Value;
                QRDataMainObj.DataColumn1 = textColumnData1.Text;
                QRDataMainObj.DataColumn2 = textColumnData2.Text;
                QRDataMainObj.DataColumn3 = textColumnData3.Text;
                QRDataMainObj.DataColumn4 = textColumnData4.Text;
                QRDataMainObj.DataColumn5 = textColumnData5.Text;
                QRDataMainObj.DataColumn6 = dtpRefilledDate.Value;
                QRDataMainObj.DataColumn7 = dtpRefillDueDate.Value;
                QRDataMainObj.DataColumn8 = textColumnData8.Text;
                QRDataMainObj.DataColumn9 = textColumnData9.Text;
                QRDataMainObj.DataColumn10 = textColumnData10.Text;

                if (QRDataMainObj.QRDataId == 0)
                {
                    QRDataMainObj.CreatedOn = DateTime.Now;

                    DatabaseHelperObj.Create(QRDataMainObj);
                    //MessageBox.Show("Record added successfully !");
                }
                else
                {
                    DatabaseHelperObj.Update(QRDataMainObj);
                    //MessageBox.Show("Record updated successfully !");
                }
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            // Close form
            this.DialogResult = DialogResult.Cancel;
        }
    }
}

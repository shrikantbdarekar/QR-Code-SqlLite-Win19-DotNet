using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder;
using System.IO;
using QRSqlLiteWin19.MyClasses;
using QRSqlLiteWin19.Reports;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace QRSqlLiteWin19
{
    public partial class FormReportViewer : Form
    {
        private List<QRData> MyQRData;
        private QRCodeGenerator qrGenerator;
        private DataTable dtObj;
        public FormReportViewer(List<QRData> MyQRData)
        {
            InitializeComponent();

            this.MyQRData = MyQRData;
            qrGenerator = new QRCodeGenerator();

            dtObj = new DataTable("QRData");
            dtObj.Columns.Add(new DataColumn("QRDataId", typeof(string)));
            dtObj.Columns.Add(new DataColumn("QRDate", typeof(DateTime)));
            dtObj.Columns.Add(new DataColumn("QRInput", typeof(string)));
            dtObj.Columns.Add(new DataColumn("QRImage", typeof(byte[])));
        }

        private void FormReportViewer_Load(object sender, EventArgs e)
        {
            FormWait FormWaitObj = new FormWait();
            FormWaitObj.Show();
            Application.DoEvents();

            foreach (QRData QData in MyQRData)
            {
                Bitmap QRIamge = GetQRImage(QData.QRInput);

                MemoryStream ms = new MemoryStream();
                QRIamge.Save(ms,System.Drawing.Imaging.ImageFormat.Bmp);

                dtObj.Rows.Add(new object[] { QData.QRDataId,QData.QRDate,QData.QRInput, ms.ToArray() });
            }

            rptQR4Inch rptQR4Inchdemo = new rptQR4Inch();
            rptQR4Inchdemo.SetDataSource(dtObj.Copy());

            crystalReportViewer1.ReportSource = rptQR4Inchdemo;

            SetExportOptions(crystalReportViewer1);

            FormWaitObj.Close();
        }

        private Bitmap GetQRImage(string QRInput)
        {
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(QRInput, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);

            //Bitmap qrCodeImage = qrCode.GetGraphic(40);

            //Set color by using Color-class types
            //Bitmap qrCodeImage = qrCode.GetGraphic(20, Color.DarkRed, Color.PaleGreen, true);
            Bitmap qrCodeImage = qrCode.GetGraphic(20, Color.Black, Color.White, true);

            //Set color by using HTML hex color notation
            //Bitmap qrCodeImage = qrCode.GetGraphic(20, "#000ff0", "#0ff000");

            //Render a logo/image in the center of the QR code
            //Bitmap qrCodeImage = qrCode.GetGraphic(20, Color.Black, Color.White, (Bitmap)Bitmap.FromFile("C:\\myimage.png"));

            //pictureBox1.Image = qrCodeImage;
            //panel1.BackgroundImage = qrCodeImage;

            return qrCodeImage;
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            // https://github.com/codebude/QRCoder

            string InputText = "The text which should be encoded.";
            if (textBoxQRTestDate.Text.Length > 0)
                InputText = textBoxQRTestDate.Text;

            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(InputText, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);

            //Bitmap qrCodeImage = qrCode.GetGraphic(40);

            //Set color by using Color-class types
            //Bitmap qrCodeImage = qrCode.GetGraphic(20, Color.DarkRed, Color.PaleGreen, true);
            Bitmap qrCodeImage = qrCode.GetGraphic(20, Color.Black, Color.White, true);

            //Set color by using HTML hex color notation
            //Bitmap qrCodeImage = qrCode.GetGraphic(20, "#000ff0", "#0ff000");

            //Render a logo/image in the center of the QR code
            //Bitmap qrCodeImage = qrCode.GetGraphic(20, Color.Black, Color.White, (Bitmap)Bitmap.FromFile("C:\\myimage.png"));

            //pictureBox1.Image = qrCodeImage;
            panelQRTestImage.BackgroundImage = qrCodeImage;

            MemoryStream ms = new MemoryStream();
            qrCodeImage.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);

            DataTable dtObj = new DataTable("DTMyItems");
            dtObj.Columns.Add(new DataColumn("ItemId", typeof(string)));
            dtObj.Columns.Add(new DataColumn("MyQRImage", typeof(byte[])));

            //List<MyItem> MyItems = new List<MyItem>();
            for (int i = 1; i < 6; i++)
            {
                //MyItems.Add(new MyItem(i.ToString(), qrCodeImage));
                dtObj.Rows.Add(new object[] { i.ToString(), ms.ToArray() });
            }

            //dataGridView1.DataSource = dtObj.Copy();

            //rptQR4Inch rptQR4Inchdemo = new rptQR4Inch();
            //rptQR4Inchdemo.SetDataSource(dtObj.Copy());

            //crystalReportViewer1.ReportSource = rptQR4Inchdemo;

        }

        private void SetExportOptions(CrystalDecisions.Windows.Forms.CrystalReportViewer viewer)
        {
            // Set export file types 

            // option 1
            // foreach not working peoperly
            //foreach (ExportFormatType formatType in Enum.GetValues(typeof(ExportFormatType)))
            //{
            //    if (formatType == ExportFormatType.PortableDocFormat ||
            //        formatType == ExportFormatType.WordForWindows ||
            //        formatType == ExportFormatType.Excel)
            //    {
            //        // Enable only PDF, Word, and Excel export options
            //        viewer.AllowedExportFormats |= (int)formatType;
            //    }
            //}

            // Option 2
            //viewer.AllowedExportFormats = (int)CrystalDecisions.Shared.ViewerExportFormats.PdfFormat;
            //viewer.AllowedExportFormats |= (int)CrystalDecisions.Shared.ViewerExportFormats.XLSXFormat;
            //viewer.AllowedExportFormats |= (int) CrystalDecisions.Shared.ViewerExportFormats.CsvFormat;

            // Set single export file type
            viewer.AllowedExportFormats = (int)CrystalDecisions.Shared.ViewerExportFormats.PdfFormat;
        }
    }
}

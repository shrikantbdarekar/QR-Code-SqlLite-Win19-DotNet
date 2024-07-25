using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QRSqlLiteWin19
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MessageBox.Show("Application Started...");

            try
            {
                // Create database if not exist
                MyClasses.DatabaseHelper DatabaseHelperObj = new MyClasses.DatabaseHelper();

            FormLogin FormLoginObj = new FormLogin();
            FormLoginObj.ShowDialog();

            if (FormLoginObj.DialogResult == DialogResult.OK)
            {
                FormQRCodeSearch FormQRCodeSearchObj = new FormQRCodeSearch();
                FormQRCodeSearchObj.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Application Closed...");

        }
    }
}

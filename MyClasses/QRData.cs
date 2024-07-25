using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QRSqlLiteWin19.MyClasses
{
    public class QRData
    {
        public long QRDataId { get; set; }
        public DateTime QRDate { get; set; }
        public string DataColumn1 { get; set; }
        public string DataColumn2 { get; set; }
        public string DataColumn3 { get; set; }
        public string DataColumn4 { get; set; }
        public string DataColumn5 { get; set; }
        //public string? DataColumn6 { get; set; }
        //public string? DataColumn7 { get; set; }
        public DateTime DataColumn6 { get; set; }
        public DateTime DataColumn7 { get; set; }
        public string DataColumn8 { get; set; }
        public string DataColumn9 { get; set; }
        public string DataColumn10 { get; set; }
        public DateTime CreatedOn { get; set; }

        public string QRInput { 
            get {
                string QROutput = "";

                if (DataColumn1 != "")
                    QROutput += Properties.Settings.Default.ColumnName1 + ":" + DataColumn1 + " | ";
                if (DataColumn2 != "")
                    QROutput+= Properties.Settings.Default.ColumnName2 + ":" + DataColumn2 + " | ";
                if (DataColumn3 != "")
                    QROutput += Properties.Settings.Default.ColumnName3 + ":" + DataColumn3 + " | ";
                if (DataColumn4 != "")
                    QROutput += Properties.Settings.Default.ColumnName4 + ":" + DataColumn4 + " | ";
                if (DataColumn5 != "")
                    QROutput += Properties.Settings.Default.ColumnName5 + ":" + DataColumn5 + " | ";
                if (DataColumn6 != null)
                    QROutput += Properties.Settings.Default.ColumnName6 + ":" + DataColumn6.ToString("dd/MM/yyy") + " | ";
                if (DataColumn7 != null)
                    QROutput += Properties.Settings.Default.ColumnName7 + ":" + DataColumn7.ToString("dd/MM/yyy") + " | ";
                if (DataColumn8 != "")
                    QROutput += Properties.Settings.Default.ColumnName8 + ":" + DataColumn8 + " | ";
                if (DataColumn9 != "")
                    QROutput += Properties.Settings.Default.ColumnName9 + ":" + DataColumn9 + " | ";
                        if (DataColumn10 != "")
                    QROutput += Properties.Settings.Default.ColumnName10 + ":" + DataColumn10;

                return QROutput;
            } 
        }
    }
}

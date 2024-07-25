using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace QRSqlLiteWin19.MyClasses
{
    class DatabaseHelper
    {
        private string connectionString = "Data Source=QRData.db;Version=3;";

        public DatabaseHelper()

        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string createTableQuery = @"
                        CREATE TABLE IF NOT EXISTS QRData (
                            QRDataId INTEGER PRIMARY KEY AUTOINCREMENT,
                            QRDate DATETIME,
                            DataColumn1 TEXT,
                            DataColumn2 TEXT,
                            DataColumn3 TEXT,
                            DataColumn4 TEXT,
                            DataColumn5 TEXT,
                            DataColumn6 DATETIME,
                            DataColumn7 DATETIME,
                            DataColumn8 TEXT,
                            DataColumn9 TEXT,
                            DataColumn10 TEXT,
                            CreatedOn DATETIME
                        )";
                using (var command = new SQLiteCommand(createTableQuery, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Create(QRData qrData)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string insertQuery = @"
    INSERT INTO QRData (QRDate, DataColumn1, DataColumn2, DataColumn3, DataColumn4, DataColumn5, DataColumn6, DataColumn7, DataColumn8, DataColumn9, DataColumn10, CreatedOn) 
    VALUES (@QRDate, @DataColumn1, @DataColumn2, @DataColumn3, @DataColumn4, @DataColumn5, @DataColumn6, @DataColumn7, @DataColumn8, @DataColumn9, @DataColumn10, @CreatedOn)";
                using (var command = new SQLiteCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@QRDate", qrData.QRDate);
                    command.Parameters.AddWithValue("@DataColumn1", qrData.DataColumn1);
                    command.Parameters.AddWithValue("@DataColumn2", qrData.DataColumn2);
                    command.Parameters.AddWithValue("@DataColumn3", qrData.DataColumn3);
                    command.Parameters.AddWithValue("@DataColumn4", qrData.DataColumn4);
                    command.Parameters.AddWithValue("@DataColumn5", qrData.DataColumn5);
                    command.Parameters.AddWithValue("@DataColumn6", qrData.DataColumn6);
                    command.Parameters.AddWithValue("@DataColumn7", qrData.DataColumn7);
                    command.Parameters.AddWithValue("@DataColumn8", qrData.DataColumn8);
                    command.Parameters.AddWithValue("@DataColumn9", qrData.DataColumn9);
                    command.Parameters.AddWithValue("@DataColumn10", qrData.DataColumn10);
                    command.Parameters.AddWithValue("@CreatedOn", qrData.CreatedOn);
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<QRData> Read()
        {
            var qrDataList = new List<QRData>();
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string selectQuery = "SELECT * FROM QRData";
                using (var command = new SQLiteCommand(selectQuery, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            qrDataList.Add(new QRData
                            {
                                QRDataId = Convert.ToInt64(reader["QRDataId"]),
                                QRDate = Convert.ToDateTime(reader["QRDate"]),
                                DataColumn1 = reader["DataColumn1"].ToString(),
                                DataColumn2 = reader["DataColumn2"].ToString(),
                                DataColumn3 = reader["DataColumn3"].ToString(),
                                DataColumn4 = reader["DataColumn4"].ToString(),
                                DataColumn5 = reader["DataColumn5"].ToString(),
                                //DataColumn6 = reader["DataColumn6"].ToString(),
                                //DataColumn7 = reader["DataColumn7"].ToString(),
                                DataColumn6 = Convert.ToDateTime(reader["DataColumn6"]),
                                DataColumn7 = Convert.ToDateTime(reader["DataColumn7"]),
                                DataColumn8 = reader["DataColumn8"].ToString(),
                                DataColumn9 = reader["DataColumn9"].ToString(),
                                DataColumn10 = reader["DataColumn10"].ToString(),
                                CreatedOn = Convert.ToDateTime(reader["CreatedOn"])
                            });
                        }
                    }
                }
            }
            return qrDataList;
        }

        public QRData Read(int QRDataId)
        {
            QRData QRDataObj = new QRData();

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string selectQuery = "SELECT * FROM QRData Where QRDataId=" + QRDataId;
                using (var command = new SQLiteCommand(selectQuery, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            QRDataObj = new QRData
                            {
                                QRDataId = Convert.ToInt64(reader["QRDataId"]),
                                QRDate = Convert.ToDateTime(reader["QRDate"]),
                                DataColumn1 = reader["DataColumn1"].ToString(),
                                DataColumn2 = reader["DataColumn2"].ToString(),
                                DataColumn3 = reader["DataColumn3"].ToString(),
                                DataColumn4 = reader["DataColumn4"].ToString(),
                                DataColumn5 = reader["DataColumn5"].ToString(),
                                //DataColumn6 = reader["DataColumn6"].ToString(),
                                //DataColumn7 = reader["DataColumn7"].ToString(),
                                DataColumn6 = Convert.ToDateTime(reader["DataColumn6"]),
                                DataColumn7 = Convert.ToDateTime(reader["DataColumn7"]),
                                DataColumn8 = reader["DataColumn8"].ToString(),
                                DataColumn9 = reader["DataColumn9"].ToString(),
                                DataColumn10 = reader["DataColumn10"].ToString(),
                                CreatedOn = Convert.ToDateTime(reader["CreatedOn"])
                            };
                        };
                    }
                }
            }
            return QRDataObj;
        }




        public void Update(QRData qrData)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string updateQuery = @"
    UPDATE QRData 
    SET QRDate = @QRDate, DataColumn1 = @DataColumn1, DataColumn2 = @DataColumn2, DataColumn3 = @DataColumn3, DataColumn4 = @DataColumn4, DataColumn5 = @DataColumn5, 
        DataColumn6 = @DataColumn6, DataColumn7 = @DataColumn7, DataColumn8 = @DataColumn8, DataColumn9 = @DataColumn9, DataColumn10 = @DataColumn10 
    WHERE QRDataId = @QRDataId"; //, CreatedOn = @CreatedOn
                using (var command = new SQLiteCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@QRDate", qrData.QRDate);
                    command.Parameters.AddWithValue("@DataColumn1", qrData.DataColumn1);
                    command.Parameters.AddWithValue("@DataColumn2", qrData.DataColumn2);
                    command.Parameters.AddWithValue("@DataColumn3", qrData.DataColumn3);
                    command.Parameters.AddWithValue("@DataColumn4", qrData.DataColumn4);
                    command.Parameters.AddWithValue("@DataColumn5", qrData.DataColumn5);
                    command.Parameters.AddWithValue("@DataColumn6", qrData.DataColumn6);
                    command.Parameters.AddWithValue("@DataColumn7", qrData.DataColumn7);
                    command.Parameters.AddWithValue("@DataColumn8", qrData.DataColumn8);
                    command.Parameters.AddWithValue("@DataColumn9", qrData.DataColumn9);
                    command.Parameters.AddWithValue("@DataColumn10", qrData.DataColumn10);
                    //command.Parameters.AddWithValue("@CreatedOn", qrData.CreatedOn);
                    command.Parameters.AddWithValue("@QRDataId", qrData.QRDataId);
                    command.ExecuteNonQuery();
                }
            }
        }

        public bool Delete(long qrDataId)
        {
            try
            {
                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    string deleteQuery = "DELETE FROM QRData WHERE QRDataId = @QRDataId";
                    using (var command = new SQLiteCommand(deleteQuery, connection))
                    {
                        command.Parameters.AddWithValue("@QRDataId", qrDataId);
                        command.ExecuteNonQuery();
                        return true;
                    }

                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<QRData> Search(string searchText, DateTime? startDate, DateTime? endDate)
        {
            var qrDataList = new List<QRData>();
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string searchQuery = "SELECT * FROM QRData WHERE 1=1";
                if (!string.IsNullOrEmpty(searchText))
                {
                    searchQuery += " AND (DataColumn1 LIKE @SearchText OR DataColumn2 LIKE @SearchText OR DataColumn3 LIKE @SearchText OR DataColumn4 LIKE @SearchText OR DataColumn5 LIKE @SearchText OR DataColumn6 LIKE @SearchText OR DataColumn7 LIKE @SearchText OR DataColumn8 LIKE @SearchText OR DataColumn9 LIKE @SearchText OR DataColumn10 LIKE @SearchText)";
                }
                if (startDate.HasValue)
                {
                    searchQuery += " AND QRDate >= @StartDate";
                }
                if (endDate.HasValue)
                {
                    searchQuery += " AND QRDate <= @EndDate";
                }
                using (var command = new SQLiteCommand(searchQuery, connection))
                {
                    if (!string.IsNullOrEmpty(searchText))
                    {
                        command.Parameters.AddWithValue("@SearchText", "%" + searchText + "%");
                    }
                    if (startDate.HasValue)
                    {
                        command.Parameters.AddWithValue("@StartDate", startDate.Value);
                    }
                    if (endDate.HasValue)
                    {
                        command.Parameters.AddWithValue("@EndDate", endDate.Value);
                    }
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            qrDataList.Add(new QRData
                            {
                                QRDataId = Convert.ToInt64(reader["QRDataId"]),
                                QRDate = Convert.ToDateTime(reader["QRDate"]),
                                DataColumn1 = reader["DataColumn1"].ToString(),
                                DataColumn2 = reader["DataColumn2"].ToString(),
                                DataColumn3 = reader["DataColumn3"].ToString(),
                                DataColumn4 = reader["DataColumn4"].ToString(),
                                DataColumn5 = reader["DataColumn5"].ToString(),
                                //DataColumn6 = reader["DataColumn6"].ToString(),
                                //DataColumn7 = reader["DataColumn7"].ToString(),
                                DataColumn6 = Convert.ToDateTime(reader["DataColumn6"]),
                                DataColumn7 = Convert.ToDateTime(reader["DataColumn7"]),
                                DataColumn8 = reader["DataColumn8"].ToString(),
                                DataColumn9 = reader["DataColumn9"].ToString(),
                                DataColumn10 = reader["DataColumn10"].ToString(),
                                CreatedOn = Convert.ToDateTime(reader["CreatedOn"])
                            });
                        }
                    }
                }
            }
            return qrDataList;


        }
    }
}

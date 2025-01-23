using cmd;
using System;
using System.Collections.Generic;
using System.Data.SqlClient; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATASTRUCTPR1
{
    internal class Data
    {
        private static string connectionString = "Data Source=LAPTOP-A0HRF6EV\\SQLEXPRESS; Initial Catalog=Nolasco; Integrated Security=True;"; // Local Connection

        private static SqlConnection sqlConnection = new SqlConnection(connectionString);

        public Data()
        {
            // Initialization already handled by static field.
        }

        public List<info> GetInfo()
        {
            var selectStatement = "SELECT * FROM cust_info";
            List<info> students = new List<info>();

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                SqlCommand selectCommand = new SqlCommand(selectStatement, sqlConnection);
                sqlConnection.Open();
                using (SqlDataReader reader = selectCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        students.Add(new info
                        {
                            CustomerName = reader["CustomerName"].ToString(),
                            CusNum = reader["CusNum"].ToString(),
                            DineorTake = reader["DineorTake"].ToString()
                        });
                    }
                }
                sqlConnection.Close();
            }

            return students;
        }

    }
}

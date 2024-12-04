using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banking__Management_System.Users_Controls_Admin
{
    public class DataBase
    {
        public static string ConnectionString = "Data Source=MARUFBILLAHS\\SQLEXPRESS;Initial Catalog=\"Banking Management\";Integrated Security=True";
        public string LastId(string query, string columnName)
        {
            try
            {
                string id = string.Empty;
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                id = reader[columnName].ToString();
                            }

                        }
                    }
                }
                return id;
            }

            catch(Exception ex)
            {
                MessageBox.Show("Class name is DataBase and function LastId and exception is " + ex.Message);
                return null;
            }
        }
    }
}

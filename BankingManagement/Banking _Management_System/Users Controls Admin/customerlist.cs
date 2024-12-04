using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using Banking__Management_System.Users_Controls_Admin;


namespace Banking__Management_System.Users_Controls_Admin
{
    public partial class customerlist : UserControl
    {
        public customerlist()
        {
            InitializeComponent();
            AdminData();
        }
        private void AdminData()
        {
            string query = $@"SELECT * 
                                FROM Person P
                                JOIN Customer A ON P.Personid = A.Personid
                                JOIN Account Z ON A.Accountid = Z.Accountid;";

            DataShow(query);
        }


        private void DataShow(string query)
        {


            SqlConnection con = new SqlConnection(DataBase.ConnectionString);
            con.Open();

            try
            {
                SqlCommand cmd = new SqlCommand(query, con);
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (!reader.Read())
                    {

                        MessageBox.Show("User not found");
                    }

                    while (reader.Read())
                    {
                        string id = reader["Personid"].ToString();
                        string name = reader["Name"].ToString();
                        string status = reader["Status"].ToString();
                        string type = reader["Type"].ToString();
                        string balance = reader["Balance"].ToString();
                        string phonenumber = reader["Phone"].ToString();

                        int rowIndex = customergrid.Rows.Add();
                        DataGridViewRow newRow = customergrid.Rows[rowIndex];
                        newRow.Cells["id"].Value = id;
                        newRow.Cells["Name"].Value = name;
                        newRow.Cells["status"].Value = status;
                        newRow.Cells["type"].Value = type;
                        newRow.Cells["balance"].Value = balance;
                        newRow.Cells["phonenumber"].Value = phonenumber;

                    }

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Class name is adminList and function name is adminData and error is " + ex.Message);
            }

        }
    }
}

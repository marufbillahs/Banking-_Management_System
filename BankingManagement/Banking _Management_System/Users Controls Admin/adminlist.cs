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
    public partial class adminlist : UserControl
    {
        public adminlist()
        {
            InitializeComponent();
            AdminData();
        }

        private void AdminData()
        {
            string query = $@"SELECT * 
                                FROM Person P
                                JOIN Admin A ON P.Personid = A.Personid
                                JOIN Zone Z ON A.Zoneid = Z.Zoneid;";

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

                    while(reader.Read())
                    {
                        string id = reader["Personid"].ToString();
                        string name = reader["Name"].ToString();
                        string zone = reader["Zonename"].ToString();
                        string nid = reader["Nid"].ToString();

                        int rowIndex = gridView.Rows.Add();
                        DataGridViewRow newRow = gridView.Rows[rowIndex];
                        newRow.Cells["Column1"].Value = id;
                        newRow.Cells["Column2"].Value = name;
                        newRow.Cells["Column3"].Value = zone;
                        newRow.Cells["Column4"].Value = nid;
                        
                    }
                   
                }
            }

            catch(Exception ex)
            {
                MessageBox.Show("Class name is adminList and function name is adminData and error is " + ex.Message);
            }
            

            

            
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(searchtb.Text))
            {
                return;
            }

            string query = $@"SELECT * 
                            FROM Person P 
                            JOIN Admin A ON P.Personid = A.Personid
                            JOIN Zone Z ON A.Zoneid = Z.Zoneid
                            WHERE P.Name LIKE %'{searchtb.Text}'%";

            DataShow(query);
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }
    }






}

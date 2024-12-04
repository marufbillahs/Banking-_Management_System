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
    public partial class employesslist : UserControl
    {
        public employesslist()
        {
            InitializeComponent();
            employeelist1();
        }

       
        private void employeelist1()
        {
            string query = $@"
							SELECT P.Personid, P.Name AS Personname, P.Phone, Z.Name AS Branchname, P.Nid
                                FROM Person P
                                JOIN Employee A ON P.Personid = A.Personid
                                JOIN Branch Z ON A.Branchid = Z.Branchid";

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
                        string id1 = reader["Personid"].ToString();
                        string name1 = reader["PersonName"].ToString();
                        string branch1 = reader["BranchName"].ToString();
                        string nid1 = reader["Nid"].ToString();
                        string phone = reader["Phone"].ToString();

                        int rowIndex = employeegridview.Rows.Add();
                        DataGridViewRow newRow = employeegridview.Rows[rowIndex];
                        newRow.Cells["id"].Value = id1;
                        newRow.Cells["name"].Value = name1;
                        newRow.Cells["branch"].Value = branch1;
                        newRow.Cells["phonenumber"].Value = phone;
                        newRow.Cells["nid"].Value = nid1;

                    }

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Class name is adminList and function name is adminData and error is " + ex.Message);
            }
  
        }
        private void searchbutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchbox.Text))
            {
                return;
            }

            string query = @"
        SELECT P.Personid, P.Name AS Personname, P.Phone, Z.Name AS Branchname, P.Nid
        FROM Person P
        JOIN Employee A ON P.Personid = A.Personid
        JOIN Branch Z ON A.Branchid = Z.Branchid
        WHERE P.Name LIKE @searchText";

            SqlConnection con = new SqlConnection(DataBase.ConnectionString);
            SqlCommand cmd = new SqlCommand(query, con);
             cmd.Parameters.AddWithValue("@searchText", "%" + searchbox.Text + "%");
             
            DataShow(query);
        }

    }
}

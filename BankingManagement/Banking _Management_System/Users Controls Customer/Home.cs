using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Banking__Management_System.Users_Controls_Admin;

namespace Banking__Management_System.Users_Controls
{
    public partial class Home : UserControl
    {
        private string userName;
        public Home()
        {
            InitializeComponent();
            
        }

        public Home(string userName) : this()
        {
            this.userName = userName;
            DataShow();

        }


        private void DataShow()
        {
            SqlConnection connection = new SqlConnection(DataBase.ConnectionString);
            connection.Open();

            try
            {
                string query = $@"SELECT A.Accountid, Balance, [Name] FROM Account A
                                    INNER JOIN Customer C ON A.Accountid = C.Accountid
                                    INNER JOIN Person P ON C.Personid = P.Personid
                                    WHERE P.Username = '{userName}'";
                SqlCommand command = new SqlCommand(query, connection);

                SqlDataReader reader = command.ExecuteReader();
                
                    if (reader.Read())
                {
                    string id = reader["Accountid"].ToString();
                    string name = reader["Name"].ToString();
                    string balance= reader["Balance"].ToString();

                    nametb.Text = name;
                    balancetb.Text = balance;
                    nubertb.Text = id;

                    nametb.Enabled = false;
                    balancetb.Enabled = false;
                    nubertb.Enabled = false;
                }
            }

            catch(Exception ex)
            {
                MessageBox.Show("Class name is Home and function name is DataShow and exception is " + ex.Message);
            }

            finally
            {
                connection.Close();
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

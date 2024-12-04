using Banking__Management_System.Users_Controls_Admin;
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
using System.Data.SqlClient;

namespace Banking__Management_System.Users_Controls_Employee
{
    public partial class edit : UserControl
    {
        public edit()
        {
            InitializeComponent();
            diablebutton();
        }

        private void diablebutton()
        {
            tbaddress.Enabled = false;
            tbnid.Enabled = false;
            tbphone.Enabled = false;
            tbmail.Enabled = false;
            tbname.Enabled = false;
            tbpassword.Enabled = false;
            updatbutton.Enabled = false;
            Deletebutton.Enabled = false;
        }

        private void enablebutton()
        {
            tbaddress.Enabled = true;
            tbnid.Enabled = true;
            tbphone.Enabled = true;
            tbmail.Enabled = true;
            tbname.Enabled = true;
            tbpassword.Enabled = true;
            updatbutton.Enabled = true;
            Deletebutton.Enabled = true;
        }

       

        private void checkbutton_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(DataBase.ConnectionString);
            con.Open();

            if(con.State == ConnectionState.Open)
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT Username FROM Person WHERE Username = '" + tbusername.Text + "'and role = 'customer'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);


                if (dt.Rows.Count != 0)
                {

                    SqlCommand cmd = new SqlCommand("SELECT * FROM Person WHERE Username = '" + tbusername.Text + "'", con);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string adrress = reader["Address"].ToString();
                        string Nid = reader["Nid"].ToString();
                        string name = reader["Name"].ToString();
                        string mail = reader["Mail"].ToString();
                        string password = reader["Password"].ToString();
                        string phone = reader["Phone"].ToString();

                        tbname.Text = name;
                        tbaddress.Text = adrress;
                        tbnid.Text = Nid;
                        tbphone.Text = phone;
                        tbmail.Text = mail;
                        tbpassword.Text = password;

                        updatbutton.Enabled = true;
                        Deletebutton.Enabled = true;
                        enablebutton();

                        
                    }
                }
                else
                {
                    MessageBox.Show("username not found");
                }
            }

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(DataBase.ConnectionString))
                {
                    // Open the database connection
                    connection.Open();
                    // Construct the DELETE query
                    string query = $@"UPDATE 
                                            Person 
                                          SET 
                                            Name = @Name, 
                                            Mail = @Email,
                                            Address= @address,
                                            Password = @Password, 
                                            Phone = @phone,
                                            Nid = @nid

                                          WHERE 
                                            Username = @username";

                    // Create the SqlCommand object with the query and connection
                    if (int.TryParse(tbphone.Text, out _) && int.TryParse(tbnid.Text, out _))
                        


                    {
                        int tbp = int.Parse(tbphone.Text);
                        int tbn = int.Parse(tbnid.Text);
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                          //  command.Parameters.Clear();
                            command.Parameters.AddWithValue("@username", tbusername.Text);
                            command.Parameters.AddWithValue("@Name", tbname.Text);
                            command.Parameters.AddWithValue("@Email", tbmail.Text);
                            command.Parameters.AddWithValue("@Address", tbaddress.Text);
                            command.Parameters.AddWithValue("@Password", tbpassword.Text);
                            command.Parameters.AddWithValue("@Phone", tbp);
                            
                            command.Parameters.AddWithValue("@nid",tbn);

                            // Execute the command to delete the data
                            int rowsAffected = command.ExecuteNonQuery();

                            // Check the number of rows affected to determine if the deletion was successful
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Data update successfully");
                                diablebutton();
                            }
                            else
                            {
                                MessageBox.Show("No data found matching the update condition");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("please recheck phone or nid");
                    }


                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Class name is DataBAse and function name is UpdateData " + ex.Message, "Error");
            }
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            //string query = $@"Delete From Customer Where CustomerId = {}";
        }
    }

       
    
}

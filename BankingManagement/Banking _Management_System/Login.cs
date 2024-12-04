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
using Banking__Management_System.Users_Controls_Admin;

namespace Banking__Management_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            loginpanel.Controls.Clear();
            loginpanel.Controls.Add(userControl);
            userControl.BringToFront();
        }
 

        private void registratio_Click(object sender, EventArgs e)
        {
            //form1 hide and form2 open
            this.Hide();
            CreateAccount f2 = new CreateAccount();
            f2.ShowDialog();
        }

        private void guna2ImageButtonPassshow_Click_1(object sender, EventArgs e)
        {

            if (Password.PasswordChar == '*')
            {
                guna2ImageButtonPassHide.BringToFront();
                Password.PasswordChar = '\0';
            }
        }

        private void guna2ImageButtonPassHide_Click_1(object sender, EventArgs e)
        {

            if (Password.PasswordChar == '\0')
            {
                guna2ImageButtonPassHide.BringToFront();
                Password.PasswordChar = '*';
            }

        }

        private void ButtonForgotPass_Click_1(object sender, EventArgs e)
        {
            forgot_password fg = new forgot_password();
            addUserControl(fg);
        }

        private void guna2ImageButtonCLose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonLogIn_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(User_Name.Text))
            {
                MessageBox.Show("Please enter username");
                return;
            }

            else if (string.IsNullOrEmpty(Password.Text))
            {
                MessageBox.Show("Please enter password");
                return;
            }
             try
                {
                    SqlConnection con = new SqlConnection(DataBase.ConnectionString);
                    con.Open(); // Open the connection

                    SqlCommand cmd = new SqlCommand("SELECT * FROM Person WHERE Username=@username AND Password=@password", con);
                    cmd.Parameters.AddWithValue("@username", User_Name.Text);
                    cmd.Parameters.AddWithValue("@password", Password.Text);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        // Check role
                        string role = reader["role"].ToString();
                        string id = reader["Personid"].ToString();
                        string name = reader["Name"].ToString();
                        // Open appropriate form based on role
                        if (role == "admin")
                        {
                            this.Hide();
                            Admin adminForm = new Admin(id, name);
                            adminForm.ShowDialog();
                        }
                        else if (role == "customer")
                        {
                            this.Hide();
                            Customer customerForm = new Customer(User_Name.Text);
                            customerForm.ShowDialog();
                        }

                        else if (role == "employee")
                        {
                            this.Hide();
                            Employee EmployeeForm = new Employee();
                            EmployeeForm.ShowDialog();
                        }


                        else
                        {
                            MessageBox.Show("Invalid role");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password");
                    }

                    reader.Close(); // Close the reader
                    con.Close(); // Close the connection
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        

       
        
    }

    
}

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
    public partial class CreateAccount : Form
    {

        public CreateAccount()
        {
            InitializeComponent();
        }

        //close button
        private void Guna2ImageButtonCLose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //back button
        private void Guna2ImageButtonBack_Click_1(object sender, EventArgs e)
        {

            this.Close();
            Login newform = new Login();
            newform.Show();
        }
        //close button
        private void guna2ImageButtonCLose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //back button
        private void guna2ImageButtonBack_Click_1(object sender, EventArgs e)
        {

            this.Close();
            Login newform = new Login();
            newform.Show();
        }







        string gender;
        private void guna2CustomRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gender = "male";
        }

        private void guna2CustomRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gender = "female";
        }

        






        




        private void guna2ButtonCreateAccount_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(DataBase.ConnectionString);
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    

                    SqlDataAdapter da = new SqlDataAdapter("SELECT Username FROM Person WHERE Username = '" + username.Text + "'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    
                    
                        



                        if (dt.Rows.Count == 0)
                        {
                            if (!string.IsNullOrWhiteSpace(fullname.Text) && !string.IsNullOrWhiteSpace(username.Text) && !string.IsNullOrWhiteSpace(password.Text) && !string.IsNullOrWhiteSpace(email.Text) && !string.IsNullOrWhiteSpace(nid.Text) && !string.IsNullOrWhiteSpace(address.Text) && !string.IsNullOrWhiteSpace(mobile.Text))
                            {
                            if (mobile.Text.Length == 11 && mobile.Text.StartsWith("01") && long.TryParse(mobile.Text, out _))
                            {
                                DataBase dataBase = new DataBase();
                                SqlCommand personquery = new SqlCommand("INSERT INTO [dbo].[Person] ([Name], [Address], [Nid], [Phone], [Mail],  [Username], [Password], [role], [Gender], [Dateofbirth])  VALUES (@name, @address, @nid, @phone, @mail, @username, @password, @role, @gender, @dateofbirth)", con);

                                personquery.Parameters.AddWithValue("@name", fullname.Text);
                                personquery.Parameters.AddWithValue("@address", address.Text);
                                personquery.Parameters.AddWithValue("@nid", nid.Text);
                                personquery.Parameters.AddWithValue("@phone", mobile.Text);
                                personquery.Parameters.AddWithValue("@mail", email.Text);
                                // personquery.Parameters.AddWithValue("@picture", DBNull.Value); 
                                personquery.Parameters.AddWithValue("@username", username.Text);
                                personquery.Parameters.AddWithValue("@password", password.Text);
                                personquery.Parameters.AddWithValue("@role", "customer");
                                personquery.Parameters.AddWithValue("@gender", gender);
                                personquery.Parameters.AddWithValue("@dateofbirth", dateTimePicker1.Value);

                                personquery.ExecuteNonQuery();

                               // int personId = (int)personquery.ExecuteScalar();

                                SqlCommand accountquery = new SqlCommand("INSERT INTO [Account] ([Balance],[Type],[Status]) VALUES (@Balance,@type, @status)", con);
                                accountquery.Parameters.AddWithValue("@balance", 0);
                                accountquery.Parameters.AddWithValue("@type", "current");
                                accountquery.Parameters.AddWithValue("@status", "active");

                                accountquery.ExecuteNonQuery();

                                //int accountId = (int)accountquery.ExecuteScalar();

                                SqlCommand customer = new SqlCommand("insert into [dbo].[Customer] ([Personid], [Accountid])  VALUES (@personid, @accountid)", con);
                                string personIdQuery = "Select Personid From Person Order By Personid DESC";
                                string accIdQuery = "Select Accountid From Account Order By Accountid DESC";

                                string lastPersonId = dataBase.LastId(personIdQuery, "Personid");
                                string lastAccId = dataBase.LastId(accIdQuery, "Accountid");

                                if (lastPersonId == string.Empty || lastAccId == string.Empty)
                                {
                                    MessageBox.Show("Class name is Createaccount function name is guna2ButtonCreateAccount_Click", "Error");
                                    return;
                                }


                                else if (lastPersonId == null || lastAccId == null)
                                    return;

                                
                                customer.Parameters.AddWithValue("@personid", lastPersonId);
                                customer.Parameters.AddWithValue("@accountid", lastAccId);

                                customer.ExecuteNonQuery();




                                fullname.Text = "";
                                address.Text = "";
                                username.Text = "";
                                password.Text = "";
                                email.Text = "";
                                nid.Text = "";
                                mobile.Text = "";
                                MessageBox.Show("perfert");
                                con.Close();
                            }


                            else
                                {
                                         MessageBox.Show("Insert phone number correctly.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Please fill all the fields.");
                            }
                        }
                   
                         else
                    {
                        fullname.Text = "";
                        address.Text = "";
                        username.Text = "";
                        password.Text = "";
                        email.Text = "";
                        nid.Text = "";
                        mobile.Text = "";
                        MessageBox.Show("username exits");
                        con.Close();
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error" +  ex.Message);

            }


           
            }





    }
}

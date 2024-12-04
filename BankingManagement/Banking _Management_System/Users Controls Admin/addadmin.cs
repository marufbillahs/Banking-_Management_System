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

namespace Banking__Management_System.Users_Controls_Admin
{
    public partial class addadmin : UserControl
    {
        public addadmin()
        {
            InitializeComponent();
        }


        int  zone;

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Zonecombobox.Text == "Dhaka") zone = 1;
            else if (Zonecombobox.Text == "Barishal") zone = 2;
            else if (Zonecombobox.Text == "Mymensingh") zone = 3;
            else if (Zonecombobox.Text == "Rajshahi") zone = 4;
            else if (Zonecombobox.Text == "Khulna") zone = 5;
            else if (Zonecombobox.Text == "Chattogram") zone = 6;
            else if (Zonecombobox.Text == "Sylhet") zone = 7;
            else if (Zonecombobox.Text == "Rangpur") zone = 8;


        }
        string gender;
        private void addbutton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(DataBase.ConnectionString);
                con.Open();
                if (con.State == ConnectionState.Open)
                {


                    SqlDataAdapter da = new SqlDataAdapter("SELECT Username FROM Person WHERE Username = '" + tbusername.Text + "'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);






                    if (dt.Rows.Count == 0)
                    {
                        if (!string.IsNullOrWhiteSpace(tbname.Text) && !string.IsNullOrWhiteSpace(tbusername.Text) && !string.IsNullOrWhiteSpace(tbpassword.Text) && !string.IsNullOrWhiteSpace(tbmail.Text) && !string.IsNullOrWhiteSpace(tbnid.Text) && !string.IsNullOrWhiteSpace(tbaddress.Text) && !string.IsNullOrWhiteSpace(tbphone.Text))
                        {
                            if (tbphone.Text.Length == 11 && tbphone.Text.StartsWith("01") && long.TryParse(tbphone.Text, out _))
                            {
                                DataBase dataBase = new DataBase();
                                SqlCommand personquery = new SqlCommand("INSERT INTO [dbo].[Person] ([Name], [Address], [Nid], [Phone], [Mail],  [Username], [Password], [role], [Gender], [Dateofbirth])  VALUES (@name, @address, @nid, @phone, @mail, @username, @password, @role, @gender, @dateofbirth)", con);

                                personquery.Parameters.AddWithValue("@name", tbname.Text);
                                personquery.Parameters.AddWithValue("@address", tbaddress.Text);
                                personquery.Parameters.AddWithValue("@nid", tbnid.Text);
                                personquery.Parameters.AddWithValue("@phone", tbphone.Text);
                                personquery.Parameters.AddWithValue("@mail", tbmail.Text);
                                // personquery.Parameters.AddWithValue("@picture", DBNull.Value); 
                                personquery.Parameters.AddWithValue("@username", tbusername.Text);
                                personquery.Parameters.AddWithValue("@password", tbpassword.Text);
                                personquery.Parameters.AddWithValue("@role", "admin");
                                personquery.Parameters.AddWithValue("@gender", gender);
                                personquery.Parameters.AddWithValue("@dateofbirth", dateTimePicker1.Value);

                                personquery.ExecuteNonQuery();

                                // int personId = (int)personquery.ExecuteScalar();


                                //int accountId = (int)accountquery.ExecuteScalar();

                                SqlCommand customer = new SqlCommand("insert into [dbo].[Admin] ( [Personid],[Zoneid])  VALUES (@personid,@zoneid)", con);
                                string personIdQuery = "Select Personid From Person Order By Personid DESC";
                                

                                string lastPersonId = dataBase.LastId(personIdQuery, "Personid");
                                

                                if (lastPersonId == string.Empty )
                                {
                                    MessageBox.Show("Class name is Createaccount function name is guna2ButtonCreateAccount_Click", "Error");
                                    return;
                                }


                                else if (lastPersonId == null )
                                    return;


                                customer.Parameters.AddWithValue("@personid", lastPersonId);
                                customer.Parameters.AddWithValue("@zoneid", zone);

                                customer.ExecuteNonQuery();




                                tbname.Text = "";
                                tbaddress.Text = "";
                                tbusername.Text = "";
                                tbpassword.Text = "";
                                tbmail.Text = "";
                                tbnid.Text = "";
                                tbphone.Text = "";
                                gender = "";
                                MessageBox.Show("Registration complete");
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
                        tbname.Text = "";
                        tbaddress.Text = "";
                        tbusername.Text = "";
                        tbpassword.Text = "";
                        tbmail.Text = "";
                        tbnid.Text = "";
                        tbphone.Text = "";
                        MessageBox.Show("username exits");
                        con.Close();
                    }

                }
            }


            catch (Exception ex)
            {
                MessageBox.Show("error:" + ex.Message);


            }
            
        }

        private void guna2CustomRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gender = "male";
        }
        private void guna2CustomRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gender = "female";
        }
    

        
    }
}

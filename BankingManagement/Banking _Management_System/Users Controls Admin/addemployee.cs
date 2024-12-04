using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Banking__Management_System.Users_Controls_Admin;
using System.Data.SqlClient;

namespace Banking__Management_System.Users_Controls_Admin
{
    public partial class addemployee : UserControl
    {
        public addemployee()
        {
            InitializeComponent();
        }

        private void initialamount_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel11_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
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
                                personquery.Parameters.AddWithValue("@role", "employee");
                                personquery.Parameters.AddWithValue("@gender", gender);
                                personquery.Parameters.AddWithValue("@dateofbirth", dateTimePicker1.Value);

                                personquery.ExecuteNonQuery();

                                // int personId = (int)personquery.ExecuteScalar();


                                //int accountId = (int)accountquery.ExecuteScalar();

                                SqlCommand Employee = new SqlCommand("insert into [dbo].[Employee] ( [Personid],[Branchid],[position])  VALUES (@personid,@branchid,@position)", con);
                                string personIdQuery = "Select Personid From Person Order By Personid DESC";


                                string lastPersonId = dataBase.LastId(personIdQuery, "Personid");


                                if (lastPersonId == string.Empty)
                                {
                                    MessageBox.Show("Class name is Createaccount function name is guna2ButtonCreateAccount_Click", "Error");
                                    return;
                                }


                                else if (lastPersonId == null)
                                    return;


                                Employee.Parameters.AddWithValue("@personid", lastPersonId);
                                Employee.Parameters.AddWithValue("@branchid", branchid);
                                Employee.Parameters.AddWithValue("@position", "Officer");


                                Employee.ExecuteNonQuery();




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
        string gender;
        int branchid;
        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (branchname.Text == "Tangail") branchid = 1;
            else if (branchname.Text == "Faridpur") branchid = 2;
            else if (branchname.Text == "Gazipur") branchid = 3;
            else if (branchname.Text == "Gopalgonj") branchid = 4;
            else if (branchname.Text == "Kishorgonj") branchid = 5;
            else if (branchname.Text == "Madarippur") branchid = 6;
            else if (branchname.Text == "Barguna") branchid = 7;
            else if (branchname.Text == "Barishal") branchid = 8;
            else if (branchname.Text == "Bhola") branchid = 9;
            else if (branchname.Text == "Patuakhali") branchid = 10;
            else if (branchname.Text == "Pirojpur") branchid = 11;
            else if (branchname.Text == "Jhalkati") branchid = 12;
            else if (branchname.Text == "Jamalpur") branchid = 13;
            else if (branchname.Text == "Sherpur") branchid = 18;
            else if (branchname.Text == "Netrokona") branchid = 19;
            else if (branchname.Text == "Thagurgaon") branchid = 25;
            else if (branchname.Text == "Nilphamari") branchid = 26;
            else if (branchname.Text == "Panchagarh") branchid = 27;
            else if (branchname.Text == "Natore") branchid = 28;
            else if (branchname.Text == "Rajshahi") branchid = 29;
            else if (branchname.Text == "Bagerhat") branchid = 36;
            else if (branchname.Text == "Chuadanga") branchid = 37;
            else if (branchname.Text == "Jessore") branchid = 38;
            else if (branchname.Text == "Jhenaidah") branchid = 39;
            else if (branchname.Text == "Khulna") branchid = 40;
            else if (branchname.Text == "Brahmanbaria") branchid = 41;
            else if (branchname.Text == "Comilla") branchid = 42;
            else if (branchname.Text == "Chandpur") branchid = 43;
            else if (branchname.Text == "Lakshmipur") branchid = 44;
            else if (branchname.Text == "Noakhali") branchid = 45;
            else if (branchname.Text == "Feni") branchid = 46;
            else if (branchname.Text == "Khagrachhari") branchid = 47;
            else if (branchname.Text == "Sylhet") branchid = 48;
            else if (branchname.Text == "Moulvibazar") branchid = 49;
            else if (branchname.Text == "Habiganj") branchid = 50;
            else if (branchname.Text == "Sunamganj") branchid = 51;
            else if (branchname.Text == "Dinajpur") branchid = 20;
            else if (branchname.Text == "Kurigram") branchid = 21;
            else if (branchname.Text == "Gaibandha") branchid = 22;
            else if (branchname.Text == "lalmonirhat") branchid = 23;
            else if (branchname.Text == "Rangpur") branchid = 24;
            
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

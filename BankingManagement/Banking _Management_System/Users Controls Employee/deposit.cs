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

namespace Banking__Management_System.Users_Controls_Employee
{
    public partial class deposit : UserControl
    {
        public deposit()
        {
            InitializeComponent();
        }

       

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private string BalanceCheck(string acNumber)
        {
            SqlConnection connection = new SqlConnection(DataBase.ConnectionString);
            connection.Open();
            try
            {

                string query = $@"SELECT A.Balance 
                                  FROM Account A
                                  WHERE A.Accountid = '{acNumber}'";

                SqlCommand command = new SqlCommand(query, connection);
                {
                    SqlDataReader reader = command.ExecuteReader();

                    // If sender A/C number match with database
                    if (reader.Read())
                        return reader["Balance"].ToString();

                    // If no data match
                    return string.Empty;

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Class name is FundTransfer function name is Balance check and error is " + ex.Message);
                return null;
            }

            finally
            {
                connection.Close();
            }
        }



        private int BalanceTransfer(int reciverCurrentBalace)
        {
            MessageBox.Show(DepositAmount.Text);

            SqlConnection connection = new SqlConnection(DataBase.ConnectionString);
            connection.Open();
            try
            {
                string sendingQuery = $"UPDATE Account SET Balance = @balance Where Accountid = @acid";

                // For updating receiver's account balance
                using (SqlCommand receivingCommand = new SqlCommand(sendingQuery, connection))
                {
                   receivingCommand.Parameters.AddWithValue("@balance", reciverCurrentBalace + Convert.ToInt32(DepositAmount.Text));
                    receivingCommand.Parameters.AddWithValue("@acid", Receiverac.Text);
                    receivingCommand.ExecuteNonQuery();
                }

                
                string sql = @"INSERT INTO [Transaction] (amount, date, Sendid, Receiveid)
                            VALUES (@amount, @date, @sendId, @receiveId)";

                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@amount", DepositAmount.Text);
                    cmd.Parameters.AddWithValue("@date", DateTime.Now);
                    cmd.Parameters.AddWithValue("@sendId", SenderAcNo.Text);
                    cmd.Parameters.AddWithValue("@receiveId", Receiverac.Text);


                    // Execute the command
                    cmd.ExecuteNonQuery();
                
                }
                




                return 1;

            }


            catch (Exception ex)
            {
                MessageBox.Show("Class name is FundTransfer function name is BalanceTransfer and error is " + ex.Message);
                return -1;
            }
            finally
            {
                connection.Close();
            }


        }

        private void Depositbutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Receiverac.Text);

            string reciverCurrentBalace = BalanceCheck(Receiverac.Text);
            

            if (reciverCurrentBalace == string.Empty)
            {
                MessageBox.Show(" account number does not match");
                return;

            }

            else if (reciverCurrentBalace == null)
                return;


            int flag = BalanceTransfer(Convert.ToInt32(reciverCurrentBalace));

            if (flag == 1)
            {
                MessageBox.Show("Send money successful");

            }

        }
    }
}

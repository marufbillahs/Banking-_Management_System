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

namespace Banking__Management_System.Users_Controls_Customer
{
    public partial class FundTransfer : UserControl
    {
    

        public FundTransfer()
        {
           
            InitializeComponent();
         

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
                    if(reader.Read())
                        return reader["Balance"].ToString();

                    // If no data match
                    return string.Empty;
                    
                }
            }

            catch(Exception ex)
            {
                MessageBox.Show("Class name is FundTransfer function name is Balance check and error is " + ex.Message);
                return null;
            }

            finally
            {
                connection.Close();
            }
        }


        private int BalanceTransfer(int senderCurrentBalance, int receiverCurrentBalance)
        {
            if (senderCurrentBalance == 0 || senderCurrentBalance < Convert.ToInt32(Amount.Text))
            {
                MessageBox.Show("Insufficient Ballance");
                return 0;
            }

            SqlConnection connection = new SqlConnection(DataBase.ConnectionString);
            connection.Open();
            try
            {
                string sendingQuery = $"UPDATE Account SET Balance = @balance Where Accountid = @acid";
                // For updating sender's account balance
                using (SqlCommand sendingCommand = new SqlCommand(sendingQuery, connection))
                {
                    sendingCommand.Parameters.AddWithValue("@balance", senderCurrentBalance - Convert.ToInt32(Amount.Text));
                    sendingCommand.Parameters.AddWithValue("@acid", SenderAcNo.Text);
                    sendingCommand.ExecuteNonQuery();
                }

                // For updating receiver's account balance
                using (SqlCommand receivingCommand = new SqlCommand(sendingQuery, connection))
                {
                    receivingCommand.Parameters.AddWithValue("@balance", receiverCurrentBalance + Convert.ToInt32(Amount.Text));
                    receivingCommand.Parameters.AddWithValue("@acid", ReceiverAcNo.Text);
                    receivingCommand.ExecuteNonQuery();
                }

                string sql = @"INSERT INTO [Transaction] (amount, date, Sendid, Receiveid)
               VALUES (@amount, @date, @sendId, @receiveId)";

                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@amount", Amount.Text);
                    cmd.Parameters.AddWithValue("@date", DateTime.Now);
                    cmd.Parameters.AddWithValue("@sendId", SenderAcNo.Text);
                    cmd.Parameters.AddWithValue("@receiveId", ReceiverAcNo.Text);
                    

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
        private void Transfer_Click(object sender, EventArgs e)
        {
            string senderCurrentBalace = BalanceCheck(SenderAcNo.Text);
            string reciverCurrentBalace = BalanceCheck(ReceiverAcNo.Text);

            if (senderCurrentBalace == string.Empty)
            {
                MessageBox.Show(" account number does not match");
                return;

            }

            else if(senderCurrentBalace == null)
                return;


            int flag = BalanceTransfer(Convert.ToInt32(senderCurrentBalace), Convert.ToInt32(reciverCurrentBalace));

            if(flag == 1)
            {
                MessageBox.Show("Send money successful");

            }
            
          


        }
    }
}

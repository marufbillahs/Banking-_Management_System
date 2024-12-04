using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banking__Management_System
{
    public partial class forgot_password : UserControl
    {
        public forgot_password()
        {
            InitializeComponent();
        }



        private void Updatepassword_Click(object sender, EventArgs e)
        {
            //form1 hide and form2 open
            this.Hide();
            Login lg = new Login();
            lg.Show();
            
            
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }
    }
}

using Banking__Management_System.Users_Controls_Admin;
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
    public partial class Admin : Form
    {
        private string id, name;
        public Admin()
        {
            InitializeComponent();

            // Design
            adminlist al = new adminlist();
            adUsercontrol(al);
            addAdminbutton.Show();
            admindetailsuc.Show();
            addemployeebutton.Hide();
            UpdateEmployeebutton.Hide();
            guna2Button2.Hide();
            allcustomerrlist.Hide();

        }


        public Admin(string id, string name) : this()
        {
            this.id = id;
            this.name = name;
            DataShow();
            idshow();
        }
        public void idshow()
        {
            this.id = id;
        }

       private void DataShow()
        {
            nameshw.Text = name;
        }
        
        
        
        

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            adminpaneltop.Controls.Clear();
            adminpaneltop.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void adUsercontrol(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            adminbottompanel.Controls.Clear();
            adminbottompanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void Adminbutton_Click(object sender, EventArgs e)
        {
            addemployeebutton.Hide();
            UpdateEmployeebutton.Hide();
            guna2Button2.Hide();
            allcustomerrlist.Hide();
            addAdminbutton.Show();
            admindetailsuc.Show();
            adminlist al = new adminlist();
            adUsercontrol(al);



            
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void employeebutton_Click(object sender, EventArgs e)
        {
            addemployeebutton.Show();
            UpdateEmployeebutton.Show();
            guna2Button2.Show();
            allcustomerrlist.Hide();
            addAdminbutton.Hide();
            admindetailsuc.Hide();
            



            employesslist cs = new employesslist();
            adUsercontrol(cs);
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            profileshow pf = new profileshow();
            adUsercontrol(pf);
        }

        private void Customerbutton_Click(object sender, EventArgs e)
        {
            customerlist cl = new customerlist();
            adUsercontrol(cl);
            addemployeebutton.Hide();
            UpdateEmployeebutton.Hide();
            guna2Button2.Hide();
            allcustomerrlist.Show();
            addAdminbutton.Hide();
            admindetailsuc.Hide();

        }

        private void guna2ImageButtonCLose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void admindetailsuc_Click(object sender, EventArgs e)
        {
            adminlist ad = new adminlist();
            adUsercontrol(ad);
        }

        private void addAdminbutton_Click(object sender, EventArgs e)
        {
            addadmin ad = new addadmin();
            adUsercontrol(ad);
        }

        private void addemployeebutton_Click(object sender, EventArgs e)
        {
            addemployee ae = new addemployee();
            adUsercontrol(ae);
        }

        private void UpdateEmployeebutton_Click(object sender, EventArgs e)
        {
            Updateemployee ue = new Updateemployee();
            adUsercontrol(ue);
        }

        private void logoutbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.ShowDialog();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            deleteemployee de = new deleteemployee();
            adUsercontrol(de);
        }
    }
}

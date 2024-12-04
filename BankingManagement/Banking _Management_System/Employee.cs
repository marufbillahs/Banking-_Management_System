using Banking__Management_System.Users_Controls_Employee;
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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
            homemployee he = new homemployee();
            addUserControl(he);
        }

        public Employee(string id, string name):this()
        {
            this.id = id;
            this.name = name;

            nameshow();
        }

        private void nameshow()
        {
            namelabel.Text = name;
        }
        public string id, name;


        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            employeebottompanel.Controls.Clear();
            employeebottompanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button2FundTrans_Click(object sender, EventArgs e)
        {
            newcustomer nc = new newcustomer();
            addUserControl(nc);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            deposit dc = new deposit();
            addUserControl(dc);
        }

        private void profilepicture_Click(object sender, EventArgs e)
        {
            employeeprofile em = new employeeprofile();
            addUserControl(em);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.ShowDialog();
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            withdraw wt = new withdraw();
            addUserControl(wt);
        }

        private void Button1Home_Click(object sender, EventArgs e)
        {
            homemployee he = new homemployee();
            addUserControl(he);
        }

        private void Editbutton_Click(object sender, EventArgs e)
        {
            edit ed = new edit();
            addUserControl(ed);
        }
    }
}

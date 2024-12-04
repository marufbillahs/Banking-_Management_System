
namespace Banking__Management_System.Users_Controls_Admin
{
    partial class adminbuttontoppanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Adminbuttonuc = new Guna.UI2.WinForms.Guna2Button();
            this.admindetailsuc = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // Adminbuttonuc
            // 
            this.Adminbuttonuc.BackColor = System.Drawing.Color.PowderBlue;
            this.Adminbuttonuc.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Adminbuttonuc.CheckedState.CustomBorderColor = System.Drawing.Color.Red;
            this.Adminbuttonuc.CustomBorderColor = System.Drawing.Color.Transparent;
            this.Adminbuttonuc.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.Adminbuttonuc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Adminbuttonuc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Adminbuttonuc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Adminbuttonuc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Adminbuttonuc.FillColor = System.Drawing.Color.PowderBlue;
            this.Adminbuttonuc.Font = new System.Drawing.Font("Segoe UI Symbol", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adminbuttonuc.ForeColor = System.Drawing.Color.Black;
            this.Adminbuttonuc.HoverState.CustomBorderColor = System.Drawing.Color.Red;
            this.Adminbuttonuc.Location = new System.Drawing.Point(561, 43);
            this.Adminbuttonuc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Adminbuttonuc.Name = "Adminbuttonuc";
            this.Adminbuttonuc.Size = new System.Drawing.Size(264, 46);
            this.Adminbuttonuc.TabIndex = 1;
            this.Adminbuttonuc.Text = " Add Admin";
            this.Adminbuttonuc.Click += new System.EventHandler(this.Adminbuttonuc_Click);
            // 
            // admindetailsuc
            // 
            this.admindetailsuc.BackColor = System.Drawing.Color.PowderBlue;
            this.admindetailsuc.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.admindetailsuc.CheckedState.CustomBorderColor = System.Drawing.Color.Red;
            this.admindetailsuc.CustomBorderColor = System.Drawing.Color.Transparent;
            this.admindetailsuc.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.admindetailsuc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.admindetailsuc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.admindetailsuc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.admindetailsuc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.admindetailsuc.FillColor = System.Drawing.Color.PowderBlue;
            this.admindetailsuc.Font = new System.Drawing.Font("Segoe UI Symbol", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admindetailsuc.ForeColor = System.Drawing.Color.Black;
            this.admindetailsuc.HoverState.CustomBorderColor = System.Drawing.Color.Red;
            this.admindetailsuc.Location = new System.Drawing.Point(199, 43);
            this.admindetailsuc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.admindetailsuc.Name = "admindetailsuc";
            this.admindetailsuc.Size = new System.Drawing.Size(295, 46);
            this.admindetailsuc.TabIndex = 2;
            this.admindetailsuc.Text = "Admin Details";
            // 
            // adminbuttontoppanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.Controls.Add(this.admindetailsuc);
            this.Controls.Add(this.Adminbuttonuc);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "adminbuttontoppanel";
            this.Size = new System.Drawing.Size(1040, 137);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button Adminbuttonuc;
        private Guna.UI2.WinForms.Guna2Button admindetailsuc;
    }
}


namespace Banking__Management_System.Users_Controls
{
    partial class Home
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
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nametb = new Guna.UI2.WinForms.Guna2TextBox();
            this.nubertb = new Guna.UI2.WinForms.Guna2TextBox();
            this.Receiver = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.balancetb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Account Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Account Name";
            // 
            // nametb
            // 
            this.nametb.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.nametb.BorderRadius = 10;
            this.nametb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nametb.DefaultText = "";
            this.nametb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nametb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nametb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nametb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nametb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nametb.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.nametb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nametb.Location = new System.Drawing.Point(203, 105);
            this.nametb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nametb.Name = "nametb";
            this.nametb.PasswordChar = '\0';
            this.nametb.PlaceholderText = "Account Name";
            this.nametb.SelectedText = "";
            this.nametb.Size = new System.Drawing.Size(185, 43);
            this.nametb.TabIndex = 76;
            this.nametb.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // nubertb
            // 
            this.nubertb.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.nubertb.BorderRadius = 10;
            this.nubertb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nubertb.DefaultText = "";
            this.nubertb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nubertb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nubertb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nubertb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nubertb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nubertb.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.nubertb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nubertb.Location = new System.Drawing.Point(206, 248);
            this.nubertb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nubertb.Name = "nubertb";
            this.nubertb.PasswordChar = '\0';
            this.nubertb.PlaceholderText = "Account num.";
            this.nubertb.SelectedText = "";
            this.nubertb.Size = new System.Drawing.Size(182, 42);
            this.nubertb.TabIndex = 78;
            // 
            // Receiver
            // 
            this.Receiver.AutoSize = true;
            this.Receiver.Font = new System.Drawing.Font("Stencil", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Receiver.ForeColor = System.Drawing.Color.DimGray;
            this.Receiver.Location = new System.Drawing.Point(350, 31);
            this.Receiver.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Receiver.Name = "Receiver";
            this.Receiver.Size = new System.Drawing.Size(138, 29);
            this.Receiver.TabIndex = 79;
            this.Receiver.Text = "WELCOME!";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BorderRadius = 10;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(647, 40);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(112, 99);
            this.guna2PictureBox1.TabIndex = 80;
            this.guna2PictureBox1.TabStop = false;
            // 
            // balancetb
            // 
            this.balancetb.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.balancetb.BorderRadius = 10;
            this.balancetb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.balancetb.DefaultText = "";
            this.balancetb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.balancetb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.balancetb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.balancetb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.balancetb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.balancetb.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.balancetb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.balancetb.Location = new System.Drawing.Point(203, 177);
            this.balancetb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.balancetb.Name = "balancetb";
            this.balancetb.PasswordChar = '\0';
            this.balancetb.PlaceholderText = "Balance";
            this.balancetb.SelectedText = "";
            this.balancetb.Size = new System.Drawing.Size(185, 43);
            this.balancetb.TabIndex = 82;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 24);
            this.label1.TabIndex = 81;
            this.label1.Text = "Account Balance";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.balancetb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.Receiver);
            this.Controls.Add(this.nubertb);
            this.Controls.Add(this.nametb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(805, 417);
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox nametb;
        private Guna.UI2.WinForms.Guna2TextBox nubertb;
        private System.Windows.Forms.Label Receiver;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox balancetb;
        private System.Windows.Forms.Label label1;
    }
}

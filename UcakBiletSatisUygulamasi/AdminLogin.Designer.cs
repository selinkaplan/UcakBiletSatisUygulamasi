namespace FlightTicketMatic_V2
{
    partial class AdminLogin
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLogin));
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.lb_password = new System.Windows.Forms.Label();
            this.lb_adminName = new System.Windows.Forms.Label();
            this.tb_adminName = new System.Windows.Forms.TextBox();
            this.lb_adminPage = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_FlightTicketMatic = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_user = new System.Windows.Forms.Button();
            this.btn_clickMe = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_login.Location = new System.Drawing.Point(345, 348);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(181, 40);
            this.btn_login.TabIndex = 40;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_clear.Location = new System.Drawing.Point(259, 348);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(80, 40);
            this.btn_clear.TabIndex = 39;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(259, 238);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(267, 20);
            this.tb_password.TabIndex = 38;
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_password.Location = new System.Drawing.Point(336, 199);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(112, 25);
            this.lb_password.TabIndex = 37;
            this.lb_password.Text = "Password:";
            // 
            // lb_adminName
            // 
            this.lb_adminName.AutoSize = true;
            this.lb_adminName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_adminName.Location = new System.Drawing.Point(330, 126);
            this.lb_adminName.Name = "lb_adminName";
            this.lb_adminName.Size = new System.Drawing.Size(140, 25);
            this.lb_adminName.TabIndex = 36;
            this.lb_adminName.Text = "Admin Name:";
            // 
            // tb_adminName
            // 
            this.tb_adminName.Location = new System.Drawing.Point(259, 165);
            this.tb_adminName.Name = "tb_adminName";
            this.tb_adminName.Size = new System.Drawing.Size(267, 20);
            this.tb_adminName.TabIndex = 35;
            // 
            // lb_adminPage
            // 
            this.lb_adminPage.AutoSize = true;
            this.lb_adminPage.BackColor = System.Drawing.SystemColors.Info;
            this.lb_adminPage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_adminPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_adminPage.Location = new System.Drawing.Point(320, 80);
            this.lb_adminPage.Name = "lb_adminPage";
            this.lb_adminPage.Size = new System.Drawing.Size(154, 27);
            this.lb_adminPage.TabIndex = 34;
            this.lb_adminPage.Text = "Admin     Page";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.lb_FlightTicketMatic);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 50);
            this.panel1.TabIndex = 33;
            // 
            // lb_FlightTicketMatic
            // 
            this.lb_FlightTicketMatic.AutoSize = true;
            this.lb_FlightTicketMatic.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold);
            this.lb_FlightTicketMatic.Location = new System.Drawing.Point(54, 9);
            this.lb_FlightTicketMatic.Name = "lb_FlightTicketMatic";
            this.lb_FlightTicketMatic.Size = new System.Drawing.Size(275, 29);
            this.lb_FlightTicketMatic.TabIndex = 4;
            this.lb_FlightTicketMatic.Text = "FlightTicketMatic-V2";
            this.lb_FlightTicketMatic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btn_user
            // 
            this.btn_user.AutoSize = true;
            this.btn_user.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_user.Location = new System.Drawing.Point(341, 499);
            this.btn_user.Name = "btn_user";
            this.btn_user.Size = new System.Drawing.Size(107, 50);
            this.btn_user.TabIndex = 43;
            this.btn_user.Text = "User Login";
            this.btn_user.UseVisualStyleBackColor = true;
            this.btn_user.Click += new System.EventHandler(this.btn_user_Click);
            // 
            // btn_clickMe
            // 
            this.btn_clickMe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clickMe.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_clickMe.Location = new System.Drawing.Point(259, 440);
            this.btn_clickMe.Name = "btn_clickMe";
            this.btn_clickMe.Size = new System.Drawing.Size(267, 36);
            this.btn_clickMe.TabIndex = 42;
            this.btn_clickMe.Text = "CLICK ME!";
            this.btn_clickMe.UseVisualStyleBackColor = true;
            this.btn_clickMe.Click += new System.EventHandler(this.btn_clickMe_Click);
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btn_user);
            this.Controls.Add(this.btn_clickMe);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.lb_password);
            this.Controls.Add(this.lb_adminName);
            this.Controls.Add(this.tb_adminName);
            this.Controls.Add(this.lb_adminPage);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "AdminLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.Label lb_adminName;
        private System.Windows.Forms.TextBox tb_adminName;
        private System.Windows.Forms.Label lb_adminPage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_FlightTicketMatic;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_user;
        private System.Windows.Forms.Button btn_clickMe;
    }
}
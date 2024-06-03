namespace FlightTicketMatic_V2
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_FlightTicketMatic = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_register = new System.Windows.Forms.Label();
            this.lb_userName = new System.Windows.Forms.Label();
            this.tb_userName = new System.Windows.Forms.TextBox();
            this.lb_password = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.lb_confirmPassword = new System.Windows.Forms.Label();
            this.tb_confirmPassword = new System.Windows.Forms.TextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_register = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_admin = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.TabIndex = 14;
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
            // lb_register
            // 
            this.lb_register.AutoSize = true;
            this.lb_register.BackColor = System.Drawing.SystemColors.Info;
            this.lb_register.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_register.Location = new System.Drawing.Point(320, 80);
            this.lb_register.Name = "lb_register";
            this.lb_register.Size = new System.Drawing.Size(150, 27);
            this.lb_register.TabIndex = 23;
            this.lb_register.Text = "Register Page";
            // 
            // lb_userName
            // 
            this.lb_userName.AutoSize = true;
            this.lb_userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_userName.Location = new System.Drawing.Point(330, 126);
            this.lb_userName.Name = "lb_userName";
            this.lb_userName.Size = new System.Drawing.Size(125, 25);
            this.lb_userName.TabIndex = 24;
            this.lb_userName.Text = "User Name:";
            // 
            // tb_userName
            // 
            this.tb_userName.Location = new System.Drawing.Point(259, 165);
            this.tb_userName.Name = "tb_userName";
            this.tb_userName.Size = new System.Drawing.Size(267, 20);
            this.tb_userName.TabIndex = 25;
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_password.Location = new System.Drawing.Point(336, 199);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(112, 25);
            this.lb_password.TabIndex = 26;
            this.lb_password.Text = "Password:";
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(259, 238);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(267, 20);
            this.tb_password.TabIndex = 27;
            // 
            // lb_confirmPassword
            // 
            this.lb_confirmPassword.AutoSize = true;
            this.lb_confirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_confirmPassword.Location = new System.Drawing.Point(296, 272);
            this.lb_confirmPassword.Name = "lb_confirmPassword";
            this.lb_confirmPassword.Size = new System.Drawing.Size(192, 25);
            this.lb_confirmPassword.TabIndex = 28;
            this.lb_confirmPassword.Text = "Confirm Password:";
            // 
            // tb_confirmPassword
            // 
            this.tb_confirmPassword.Location = new System.Drawing.Point(259, 311);
            this.tb_confirmPassword.Name = "tb_confirmPassword";
            this.tb_confirmPassword.Size = new System.Drawing.Size(267, 20);
            this.tb_confirmPassword.TabIndex = 29;
            // 
            // btn_clear
            // 
            this.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_clear.Location = new System.Drawing.Point(259, 348);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(80, 40);
            this.btn_clear.TabIndex = 30;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_register
            // 
            this.btn_register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_register.Location = new System.Drawing.Point(345, 348);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(181, 40);
            this.btn_register.TabIndex = 31;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // btn_login
            // 
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_login.Location = new System.Drawing.Point(259, 394);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(267, 40);
            this.btn_login.TabIndex = 32;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_admin
            // 
            this.btn_admin.AutoSize = true;
            this.btn_admin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_admin.Location = new System.Drawing.Point(341, 499);
            this.btn_admin.Name = "btn_admin";
            this.btn_admin.Size = new System.Drawing.Size(107, 50);
            this.btn_admin.TabIndex = 5;
            this.btn_admin.Text = "Admin Login";
            this.btn_admin.UseVisualStyleBackColor = true;
            this.btn_admin.Click += new System.EventHandler(this.btn_admin_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btn_admin);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.tb_confirmPassword);
            this.Controls.Add(this.lb_confirmPassword);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.lb_password);
            this.Controls.Add(this.tb_userName);
            this.Controls.Add(this.lb_userName);
            this.Controls.Add(this.lb_register);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_FlightTicketMatic;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_register;
        private System.Windows.Forms.Label lb_userName;
        private System.Windows.Forms.TextBox tb_userName;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label lb_confirmPassword;
        private System.Windows.Forms.TextBox tb_confirmPassword;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_admin;
    }
}
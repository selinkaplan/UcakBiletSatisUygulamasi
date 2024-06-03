namespace FlightTicketMatic_V2
{
    partial class AdminPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            this.nav1 = new System.Windows.Forms.Panel();
            this.btn_logout = new System.Windows.Forms.Button();
            this.lb_FlightTicketMatic = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_adminName = new System.Windows.Forms.Label();
            this.nav2 = new System.Windows.Forms.Panel();
            this.tab_flight = new System.Windows.Forms.Button();
            this.tab_plane = new System.Windows.Forms.Button();
            this.tab_home = new System.Windows.Forms.Button();
            this.pnl_container = new System.Windows.Forms.Panel();
            this.nav1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.nav2.SuspendLayout();
            this.SuspendLayout();
            // 
            // nav1
            // 
            this.nav1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.nav1.Controls.Add(this.btn_logout);
            this.nav1.Controls.Add(this.lb_FlightTicketMatic);
            this.nav1.Controls.Add(this.pictureBox1);
            this.nav1.Controls.Add(this.lb_adminName);
            this.nav1.Dock = System.Windows.Forms.DockStyle.Top;
            this.nav1.Location = new System.Drawing.Point(0, 0);
            this.nav1.Name = "nav1";
            this.nav1.Size = new System.Drawing.Size(784, 50);
            this.nav1.TabIndex = 1;
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_logout.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Image = ((System.Drawing.Image)(resources.GetObject("btn_logout.Image")));
            this.btn_logout.Location = new System.Drawing.Point(733, 0);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(51, 50);
            this.btn_logout.TabIndex = 4;
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // lb_FlightTicketMatic
            // 
            this.lb_FlightTicketMatic.AutoSize = true;
            this.lb_FlightTicketMatic.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold);
            this.lb_FlightTicketMatic.Location = new System.Drawing.Point(54, 9);
            this.lb_FlightTicketMatic.Name = "lb_FlightTicketMatic";
            this.lb_FlightTicketMatic.Size = new System.Drawing.Size(275, 29);
            this.lb_FlightTicketMatic.TabIndex = 3;
            this.lb_FlightTicketMatic.Text = "FlightTicketMatic-V2";
            this.lb_FlightTicketMatic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lb_adminName
            // 
            this.lb_adminName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lb_adminName.Location = new System.Drawing.Point(335, 9);
            this.lb_adminName.Name = "lb_adminName";
            this.lb_adminName.Size = new System.Drawing.Size(392, 29);
            this.lb_adminName.TabIndex = 5;
            this.lb_adminName.Text = "Admin Name";
            this.lb_adminName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nav2
            // 
            this.nav2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.nav2.Controls.Add(this.tab_flight);
            this.nav2.Controls.Add(this.tab_plane);
            this.nav2.Controls.Add(this.tab_home);
            this.nav2.Dock = System.Windows.Forms.DockStyle.Top;
            this.nav2.Location = new System.Drawing.Point(0, 50);
            this.nav2.Name = "nav2";
            this.nav2.Size = new System.Drawing.Size(784, 50);
            this.nav2.TabIndex = 2;
            // 
            // tab_flight
            // 
            this.tab_flight.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tab_flight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tab_flight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tab_flight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tab_flight.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tab_flight.Location = new System.Drawing.Point(316, 0);
            this.tab_flight.Name = "tab_flight";
            this.tab_flight.Size = new System.Drawing.Size(152, 50);
            this.tab_flight.TabIndex = 100;
            this.tab_flight.Text = "Flight";
            this.tab_flight.UseVisualStyleBackColor = false;
            this.tab_flight.Click += new System.EventHandler(this.tab_flight_Click);
            // 
            // tab_plane
            // 
            this.tab_plane.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tab_plane.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tab_plane.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tab_plane.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tab_plane.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tab_plane.Location = new System.Drawing.Point(158, 0);
            this.tab_plane.Name = "tab_plane";
            this.tab_plane.Size = new System.Drawing.Size(152, 50);
            this.tab_plane.TabIndex = 99;
            this.tab_plane.Text = "Plane";
            this.tab_plane.UseVisualStyleBackColor = false;
            this.tab_plane.Click += new System.EventHandler(this.tab_plane_Click);
            // 
            // tab_home
            // 
            this.tab_home.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tab_home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tab_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tab_home.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tab_home.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tab_home.Location = new System.Drawing.Point(0, 0);
            this.tab_home.Name = "tab_home";
            this.tab_home.Size = new System.Drawing.Size(152, 50);
            this.tab_home.TabIndex = 97;
            this.tab_home.Text = "Home";
            this.tab_home.UseVisualStyleBackColor = false;
            this.tab_home.Click += new System.EventHandler(this.tab_home_Click);
            // 
            // pnl_container
            // 
            this.pnl_container.BackColor = System.Drawing.SystemColors.Control;
            this.pnl_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_container.Location = new System.Drawing.Point(0, 100);
            this.pnl_container.Name = "pnl_container";
            this.pnl_container.Size = new System.Drawing.Size(784, 461);
            this.pnl_container.TabIndex = 3;
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pnl_container);
            this.Controls.Add(this.nav2);
            this.Controls.Add(this.nav1);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPanel";
            this.nav1.ResumeLayout(false);
            this.nav1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.nav2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel nav1;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Label lb_FlightTicketMatic;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_adminName;
        private System.Windows.Forms.Panel nav2;
        private System.Windows.Forms.Button tab_flight;
        private System.Windows.Forms.Button tab_plane;
        private System.Windows.Forms.Button tab_home;
        private System.Windows.Forms.Panel pnl_container;
    }
}
namespace FlightTicketMatic_V2
{
    partial class FlightTicketMatic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlightTicketMatic));
            this.pnl_container = new System.Windows.Forms.Panel();
            this.tab_home = new System.Windows.Forms.Button();
            this.nav2 = new System.Windows.Forms.Panel();
            this.tab_reservation = new System.Windows.Forms.Button();
            this.tab_location = new System.Windows.Forms.Button();
            this.tab_seat = new System.Windows.Forms.Button();
            this.lb_userName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_FlightTicketMatic = new System.Windows.Forms.Label();
            this.btn_logout = new System.Windows.Forms.Button();
            this.nav1 = new System.Windows.Forms.Panel();
            this.nav2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.nav1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_container
            // 
            this.pnl_container.BackColor = System.Drawing.SystemColors.Control;
            this.pnl_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_container.Location = new System.Drawing.Point(0, 100);
            this.pnl_container.Name = "pnl_container";
            this.pnl_container.Size = new System.Drawing.Size(784, 461);
            this.pnl_container.TabIndex = 2;
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
            this.tab_home.Click += new System.EventHandler(this.tab_Home_Click);
            // 
            // nav2
            // 
            this.nav2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.nav2.Controls.Add(this.tab_reservation);
            this.nav2.Controls.Add(this.tab_location);
            this.nav2.Controls.Add(this.tab_seat);
            this.nav2.Controls.Add(this.tab_home);
            this.nav2.Dock = System.Windows.Forms.DockStyle.Top;
            this.nav2.Location = new System.Drawing.Point(0, 50);
            this.nav2.Name = "nav2";
            this.nav2.Size = new System.Drawing.Size(784, 50);
            this.nav2.TabIndex = 1;
            // 
            // tab_reservation
            // 
            this.tab_reservation.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tab_reservation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tab_reservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tab_reservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tab_reservation.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tab_reservation.Location = new System.Drawing.Point(474, 0);
            this.tab_reservation.Name = "tab_reservation";
            this.tab_reservation.Size = new System.Drawing.Size(152, 50);
            this.tab_reservation.TabIndex = 100;
            this.tab_reservation.Text = "Reservation";
            this.tab_reservation.UseVisualStyleBackColor = false;
            this.tab_reservation.Click += new System.EventHandler(this.tab_Reservation_Click);
            // 
            // tab_location
            // 
            this.tab_location.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tab_location.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tab_location.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tab_location.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tab_location.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tab_location.Location = new System.Drawing.Point(158, 0);
            this.tab_location.Name = "tab_location";
            this.tab_location.Size = new System.Drawing.Size(152, 50);
            this.tab_location.TabIndex = 99;
            this.tab_location.Text = "Location";
            this.tab_location.UseVisualStyleBackColor = false;
            this.tab_location.Click += new System.EventHandler(this.tab_Location_Click);
            // 
            // tab_seat
            // 
            this.tab_seat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tab_seat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tab_seat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tab_seat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tab_seat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tab_seat.Location = new System.Drawing.Point(316, 0);
            this.tab_seat.Name = "tab_seat";
            this.tab_seat.Size = new System.Drawing.Size(152, 50);
            this.tab_seat.TabIndex = 98;
            this.tab_seat.Text = "Seat";
            this.tab_seat.UseVisualStyleBackColor = false;
            this.tab_seat.Click += new System.EventHandler(this.tab_Seat_Click);
            // 
            // lb_userName
            // 
            this.lb_userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lb_userName.Location = new System.Drawing.Point(335, 9);
            this.lb_userName.Name = "lb_userName";
            this.lb_userName.Size = new System.Drawing.Size(392, 29);
            this.lb_userName.TabIndex = 5;
            this.lb_userName.Text = "User Name";
            this.lb_userName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // nav1
            // 
            this.nav1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.nav1.Controls.Add(this.btn_logout);
            this.nav1.Controls.Add(this.lb_FlightTicketMatic);
            this.nav1.Controls.Add(this.pictureBox1);
            this.nav1.Controls.Add(this.lb_userName);
            this.nav1.Dock = System.Windows.Forms.DockStyle.Top;
            this.nav1.Location = new System.Drawing.Point(0, 0);
            this.nav1.Name = "nav1";
            this.nav1.Size = new System.Drawing.Size(784, 50);
            this.nav1.TabIndex = 0;
            // 
            // FlightTicketMatic
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
            this.Name = "FlightTicketMatic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FlightTicketMatic_V2";
            this.nav2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.nav1.ResumeLayout(false);
            this.nav1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_container;
        private System.Windows.Forms.Button tab_home;
        private System.Windows.Forms.Panel nav2;
        private System.Windows.Forms.Label lb_userName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_FlightTicketMatic;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Panel nav1;
        private System.Windows.Forms.Button tab_seat;
        private System.Windows.Forms.Button tab_reservation;
        private System.Windows.Forms.Button tab_location;
    }
}


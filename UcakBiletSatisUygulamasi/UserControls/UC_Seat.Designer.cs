namespace FlightTicketMatic_V2.UserControls
{
    partial class UC_Seat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Seat));
            this.lb_selectedSeats = new System.Windows.Forms.Label();
            this.pb_confirmSeats = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_confirmSeats)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_selectedSeats
            // 
            this.lb_selectedSeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_selectedSeats.Location = new System.Drawing.Point(3, 377);
            this.lb_selectedSeats.Name = "lb_selectedSeats";
            this.lb_selectedSeats.Size = new System.Drawing.Size(724, 84);
            this.lb_selectedSeats.TabIndex = 0;
            this.lb_selectedSeats.Text = "SelectedSeats:";
            // 
            // pb_confirmSeats
            // 
            this.pb_confirmSeats.Image = ((System.Drawing.Image)(resources.GetObject("pb_confirmSeats.Image")));
            this.pb_confirmSeats.Location = new System.Drawing.Point(733, 410);
            this.pb_confirmSeats.Name = "pb_confirmSeats";
            this.pb_confirmSeats.Size = new System.Drawing.Size(48, 48);
            this.pb_confirmSeats.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_confirmSeats.TabIndex = 1;
            this.pb_confirmSeats.TabStop = false;
            this.pb_confirmSeats.Click += new System.EventHandler(this.pb_confirmSeats_Click);
            // 
            // UC_Seat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pb_confirmSeats);
            this.Controls.Add(this.lb_selectedSeats);
            this.Name = "UC_Seat";
            this.Size = new System.Drawing.Size(784, 461);
            ((System.ComponentModel.ISupportInitialize)(this.pb_confirmSeats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_selectedSeats;
        private System.Windows.Forms.PictureBox pb_confirmSeats;
    }
}

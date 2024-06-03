namespace FlightTicketMatic_V2.AdminControls
{
    partial class AC_Home
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
            this.lb_home = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_home
            // 
            this.lb_home.AutoSize = true;
            this.lb_home.Font = new System.Drawing.Font("ROG Fonts", 33.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_home.Location = new System.Drawing.Point(194, 203);
            this.lb_home.Name = "lb_home";
            this.lb_home.Size = new System.Drawing.Size(397, 54);
            this.lb_home.TabIndex = 4;
            this.lb_home.Text = "Admin Panel";
            // 
            // AC_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lb_home);
            this.Name = "AC_Home";
            this.Size = new System.Drawing.Size(784, 461);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_home;
    }
}

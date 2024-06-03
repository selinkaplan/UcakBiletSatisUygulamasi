namespace FlightTicketMatic_V2.AdminControls
{
    partial class AC_Flight
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
            this.lb_departure = new System.Windows.Forms.Label();
            this.lb_toLocation = new System.Windows.Forms.Label();
            this.lb_fromLocation = new System.Windows.Forms.Label();
            this.lb_planeId = new System.Windows.Forms.Label();
            this.dtp_departureDate = new System.Windows.Forms.DateTimePicker();
            this.cb_planeId = new System.Windows.Forms.ComboBox();
            this.btn_confirmPlane = new System.Windows.Forms.Button();
            this.tb_from = new System.Windows.Forms.TextBox();
            this.tb_to = new System.Windows.Forms.TextBox();
            this.dtp_departureTime = new System.Windows.Forms.DateTimePicker();
            this.dgv_flights = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fromLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_flights)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_departure
            // 
            this.lb_departure.AutoSize = true;
            this.lb_departure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_departure.Location = new System.Drawing.Point(10, 98);
            this.lb_departure.Name = "lb_departure";
            this.lb_departure.Size = new System.Drawing.Size(120, 20);
            this.lb_departure.TabIndex = 12;
            this.lb_departure.Text = "Departure Date";
            // 
            // lb_toLocation
            // 
            this.lb_toLocation.AutoSize = true;
            this.lb_toLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_toLocation.Location = new System.Drawing.Point(10, 56);
            this.lb_toLocation.Name = "lb_toLocation";
            this.lb_toLocation.Size = new System.Drawing.Size(92, 20);
            this.lb_toLocation.TabIndex = 11;
            this.lb_toLocation.Text = "To Location";
            // 
            // lb_fromLocation
            // 
            this.lb_fromLocation.AutoSize = true;
            this.lb_fromLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_fromLocation.Location = new System.Drawing.Point(10, 14);
            this.lb_fromLocation.Name = "lb_fromLocation";
            this.lb_fromLocation.Size = new System.Drawing.Size(111, 20);
            this.lb_fromLocation.TabIndex = 7;
            this.lb_fromLocation.Text = "From Location";
            // 
            // lb_planeId
            // 
            this.lb_planeId.AutoSize = true;
            this.lb_planeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_planeId.Location = new System.Drawing.Point(10, 140);
            this.lb_planeId.Name = "lb_planeId";
            this.lb_planeId.Size = new System.Drawing.Size(67, 20);
            this.lb_planeId.TabIndex = 14;
            this.lb_planeId.Text = "Plane Id";
            // 
            // dtp_departureDate
            // 
            this.dtp_departureDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_departureDate.Location = new System.Drawing.Point(146, 98);
            this.dtp_departureDate.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dtp_departureDate.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtp_departureDate.Name = "dtp_departureDate";
            this.dtp_departureDate.ShowUpDown = true;
            this.dtp_departureDate.Size = new System.Drawing.Size(120, 20);
            this.dtp_departureDate.TabIndex = 17;
            this.dtp_departureDate.Value = new System.DateTime(2024, 5, 29, 19, 32, 40, 0);
            // 
            // cb_planeId
            // 
            this.cb_planeId.FormattingEnabled = true;
            this.cb_planeId.Location = new System.Drawing.Point(146, 142);
            this.cb_planeId.Name = "cb_planeId";
            this.cb_planeId.Size = new System.Drawing.Size(200, 21);
            this.cb_planeId.TabIndex = 18;
            // 
            // btn_confirmPlane
            // 
            this.btn_confirmPlane.AutoSize = true;
            this.btn_confirmPlane.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_confirmPlane.Location = new System.Drawing.Point(391, 130);
            this.btn_confirmPlane.Name = "btn_confirmPlane";
            this.btn_confirmPlane.Size = new System.Drawing.Size(96, 37);
            this.btn_confirmPlane.TabIndex = 19;
            this.btn_confirmPlane.Text = "Confirm";
            this.btn_confirmPlane.UseVisualStyleBackColor = true;
            this.btn_confirmPlane.Click += new System.EventHandler(this.btn_confirmFlight_Click);
            // 
            // tb_from
            // 
            this.tb_from.Location = new System.Drawing.Point(146, 13);
            this.tb_from.Name = "tb_from";
            this.tb_from.Size = new System.Drawing.Size(200, 20);
            this.tb_from.TabIndex = 20;
            this.tb_from.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_from_KeyPress);
            // 
            // tb_to
            // 
            this.tb_to.Location = new System.Drawing.Point(146, 56);
            this.tb_to.Name = "tb_to";
            this.tb_to.Size = new System.Drawing.Size(200, 20);
            this.tb_to.TabIndex = 21;
            this.tb_to.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_to_KeyPress);
            // 
            // dtp_departureTime
            // 
            this.dtp_departureTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_departureTime.Location = new System.Drawing.Point(266, 98);
            this.dtp_departureTime.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dtp_departureTime.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtp_departureTime.Name = "dtp_departureTime";
            this.dtp_departureTime.ShowUpDown = true;
            this.dtp_departureTime.Size = new System.Drawing.Size(80, 20);
            this.dtp_departureTime.TabIndex = 22;
            this.dtp_departureTime.Value = new System.DateTime(2024, 5, 29, 19, 32, 40, 0);
            // 
            // dgv_flights
            // 
            this.dgv_flights.AllowUserToAddRows = false;
            this.dgv_flights.AllowUserToDeleteRows = false;
            this.dgv_flights.AllowUserToResizeColumns = false;
            this.dgv_flights.AllowUserToResizeRows = false;
            this.dgv_flights.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_flights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_flights.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.fromLocation,
            this.toLocation,
            this.departureDate,
            this.departureTime,
            this.planeId});
            this.dgv_flights.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_flights.Location = new System.Drawing.Point(0, 185);
            this.dgv_flights.Name = "dgv_flights";
            this.dgv_flights.ReadOnly = true;
            this.dgv_flights.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_flights.Size = new System.Drawing.Size(784, 276);
            this.dgv_flights.TabIndex = 23;
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // fromLocation
            // 
            this.fromLocation.HeaderText = "From Location";
            this.fromLocation.Name = "fromLocation";
            this.fromLocation.ReadOnly = true;
            // 
            // toLocation
            // 
            this.toLocation.HeaderText = "To Location";
            this.toLocation.Name = "toLocation";
            this.toLocation.ReadOnly = true;
            // 
            // departureDate
            // 
            this.departureDate.HeaderText = "Departure Date";
            this.departureDate.Name = "departureDate";
            this.departureDate.ReadOnly = true;
            // 
            // departureTime
            // 
            this.departureTime.HeaderText = "Departure Time";
            this.departureTime.Name = "departureTime";
            this.departureTime.ReadOnly = true;
            // 
            // planeId
            // 
            this.planeId.HeaderText = "Plane Id";
            this.planeId.Name = "planeId";
            this.planeId.ReadOnly = true;
            // 
            // AC_Flight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_flights);
            this.Controls.Add(this.dtp_departureTime);
            this.Controls.Add(this.tb_to);
            this.Controls.Add(this.tb_from);
            this.Controls.Add(this.btn_confirmPlane);
            this.Controls.Add(this.cb_planeId);
            this.Controls.Add(this.dtp_departureDate);
            this.Controls.Add(this.lb_planeId);
            this.Controls.Add(this.lb_departure);
            this.Controls.Add(this.lb_toLocation);
            this.Controls.Add(this.lb_fromLocation);
            this.Name = "AC_Flight";
            this.Size = new System.Drawing.Size(784, 461);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_flights)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_departure;
        private System.Windows.Forms.Label lb_toLocation;
        private System.Windows.Forms.Label lb_fromLocation;
        private System.Windows.Forms.Label lb_planeId;
        private System.Windows.Forms.DateTimePicker dtp_departureDate;
        private System.Windows.Forms.ComboBox cb_planeId;
        private System.Windows.Forms.Button btn_confirmPlane;
        private System.Windows.Forms.TextBox tb_from;
        private System.Windows.Forms.TextBox tb_to;
        private System.Windows.Forms.DateTimePicker dtp_departureTime;
        private System.Windows.Forms.DataGridView dgv_flights;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fromLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn toLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn departureDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn departureTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn planeId;
    }
}

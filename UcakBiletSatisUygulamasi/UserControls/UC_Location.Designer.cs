namespace FlightTicketMatic_V2.UserControls
{
    partial class UC_Location
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
            this.lb_from = new System.Windows.Forms.Label();
            this.lb_to = new System.Windows.Forms.Label();
            this.rb_oneWay = new System.Windows.Forms.RadioButton();
            this.rb_roundTrip = new System.Windows.Forms.RadioButton();
            this.rb_multiLegFlight = new System.Windows.Forms.RadioButton();
            this.cb_from = new System.Windows.Forms.ComboBox();
            this.cb_to = new System.Windows.Forms.ComboBox();
            this.dgv_flights = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.from = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.to = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.select = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_flights)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_from
            // 
            this.lb_from.AutoSize = true;
            this.lb_from.Location = new System.Drawing.Point(13, 8);
            this.lb_from.Name = "lb_from";
            this.lb_from.Size = new System.Drawing.Size(30, 13);
            this.lb_from.TabIndex = 0;
            this.lb_from.Text = "From";
            // 
            // lb_to
            // 
            this.lb_to.AutoSize = true;
            this.lb_to.Location = new System.Drawing.Point(249, 8);
            this.lb_to.Name = "lb_to";
            this.lb_to.Size = new System.Drawing.Size(20, 13);
            this.lb_to.TabIndex = 1;
            this.lb_to.Text = "To";
            // 
            // rb_oneWay
            // 
            this.rb_oneWay.AutoSize = true;
            this.rb_oneWay.Checked = true;
            this.rb_oneWay.Location = new System.Drawing.Point(475, 13);
            this.rb_oneWay.Name = "rb_oneWay";
            this.rb_oneWay.Size = new System.Drawing.Size(70, 17);
            this.rb_oneWay.TabIndex = 2;
            this.rb_oneWay.TabStop = true;
            this.rb_oneWay.Text = "One-Way";
            this.rb_oneWay.UseVisualStyleBackColor = true;
            // 
            // rb_roundTrip
            // 
            this.rb_roundTrip.AutoSize = true;
            this.rb_roundTrip.Enabled = false;
            this.rb_roundTrip.Location = new System.Drawing.Point(573, 13);
            this.rb_roundTrip.Name = "rb_roundTrip";
            this.rb_roundTrip.Size = new System.Drawing.Size(78, 17);
            this.rb_roundTrip.TabIndex = 3;
            this.rb_roundTrip.TabStop = true;
            this.rb_roundTrip.Text = "Round Trip";
            this.rb_roundTrip.UseVisualStyleBackColor = true;
            // 
            // rb_multiLegFlight
            // 
            this.rb_multiLegFlight.AutoSize = true;
            this.rb_multiLegFlight.Enabled = false;
            this.rb_multiLegFlight.Location = new System.Drawing.Point(679, 13);
            this.rb_multiLegFlight.Name = "rb_multiLegFlight";
            this.rb_multiLegFlight.Size = new System.Drawing.Size(92, 17);
            this.rb_multiLegFlight.TabIndex = 4;
            this.rb_multiLegFlight.TabStop = true;
            this.rb_multiLegFlight.Text = "Multi-leg Flight";
            this.rb_multiLegFlight.UseVisualStyleBackColor = true;
            // 
            // cb_from
            // 
            this.cb_from.FormattingEnabled = true;
            this.cb_from.Location = new System.Drawing.Point(16, 38);
            this.cb_from.Name = "cb_from";
            this.cb_from.Size = new System.Drawing.Size(150, 21);
            this.cb_from.TabIndex = 10;
            this.cb_from.DropDownClosed += new System.EventHandler(this.cb_from_DropDownClosed);
            // 
            // cb_to
            // 
            this.cb_to.FormattingEnabled = true;
            this.cb_to.Location = new System.Drawing.Point(252, 38);
            this.cb_to.Name = "cb_to";
            this.cb_to.Size = new System.Drawing.Size(150, 21);
            this.cb_to.TabIndex = 11;
            this.cb_to.DropDownClosed += new System.EventHandler(this.cb_to_DropDownClosed);
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
            this.from,
            this.to,
            this.departureDate,
            this.departureTime,
            this.planeId,
            this.select});
            this.dgv_flights.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_flights.Location = new System.Drawing.Point(0, 116);
            this.dgv_flights.Name = "dgv_flights";
            this.dgv_flights.ReadOnly = true;
            this.dgv_flights.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_flights.Size = new System.Drawing.Size(784, 345);
            this.dgv_flights.TabIndex = 12;
            this.dgv_flights.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_flights_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // from
            // 
            this.from.HeaderText = "From";
            this.from.Name = "from";
            this.from.ReadOnly = true;
            // 
            // to
            // 
            this.to.HeaderText = "To";
            this.to.Name = "to";
            this.to.ReadOnly = true;
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
            // select
            // 
            this.select.HeaderText = "Select";
            this.select.Name = "select";
            this.select.ReadOnly = true;
            this.select.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.select.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // UC_Location
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_flights);
            this.Controls.Add(this.cb_to);
            this.Controls.Add(this.cb_from);
            this.Controls.Add(this.rb_multiLegFlight);
            this.Controls.Add(this.rb_roundTrip);
            this.Controls.Add(this.rb_oneWay);
            this.Controls.Add(this.lb_to);
            this.Controls.Add(this.lb_from);
            this.Name = "UC_Location";
            this.Size = new System.Drawing.Size(784, 461);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_flights)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_from;
        private System.Windows.Forms.Label lb_to;
        private System.Windows.Forms.RadioButton rb_oneWay;
        private System.Windows.Forms.RadioButton rb_roundTrip;
        private System.Windows.Forms.RadioButton rb_multiLegFlight;
        private System.Windows.Forms.ComboBox cb_from;
        private System.Windows.Forms.ComboBox cb_to;
        private System.Windows.Forms.DataGridView dgv_flights;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn from;
        private System.Windows.Forms.DataGridViewTextBoxColumn to;
        private System.Windows.Forms.DataGridViewTextBoxColumn departureDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn departureTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn planeId;
        private System.Windows.Forms.DataGridViewButtonColumn select;
    }
}

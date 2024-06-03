namespace FlightTicketMatic_V2.AdminControls
{
    partial class AC_Plane
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
            this.components = new System.ComponentModel.Container();
            this.lb_airline = new System.Windows.Forms.Label();
            this.tb_airline = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tb_seatCapacity = new System.Windows.Forms.TextBox();
            this.tb_serialNo = new System.Windows.Forms.TextBox();
            this.lb_serialNo = new System.Windows.Forms.Label();
            this.lb_seatCapacity = new System.Windows.Forms.Label();
            this.btn_confirmFlight = new System.Windows.Forms.Button();
            this.lb_seatInfo = new System.Windows.Forms.Label();
            this.dgv_planes = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.airline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seatCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_planes)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_airline
            // 
            this.lb_airline.AutoSize = true;
            this.lb_airline.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_airline.Location = new System.Drawing.Point(11, 18);
            this.lb_airline.Name = "lb_airline";
            this.lb_airline.Size = new System.Drawing.Size(52, 20);
            this.lb_airline.TabIndex = 0;
            this.lb_airline.Text = "Airline";
            // 
            // tb_airline
            // 
            this.tb_airline.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_airline.Location = new System.Drawing.Point(147, 18);
            this.tb_airline.MaxLength = 6;
            this.tb_airline.Name = "tb_airline";
            this.tb_airline.Size = new System.Drawing.Size(200, 20);
            this.tb_airline.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tb_seatCapacity
            // 
            this.tb_seatCapacity.Location = new System.Drawing.Point(147, 88);
            this.tb_seatCapacity.Name = "tb_seatCapacity";
            this.tb_seatCapacity.Size = new System.Drawing.Size(200, 20);
            this.tb_seatCapacity.TabIndex = 3;
            this.tb_seatCapacity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_seatCapacity_KeyPress);
            // 
            // tb_serialNo
            // 
            this.tb_serialNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_serialNo.Location = new System.Drawing.Point(147, 55);
            this.tb_serialNo.MaxLength = 6;
            this.tb_serialNo.Name = "tb_serialNo";
            this.tb_serialNo.Size = new System.Drawing.Size(200, 20);
            this.tb_serialNo.TabIndex = 4;
            // 
            // lb_serialNo
            // 
            this.lb_serialNo.AutoSize = true;
            this.lb_serialNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_serialNo.Location = new System.Drawing.Point(11, 53);
            this.lb_serialNo.Name = "lb_serialNo";
            this.lb_serialNo.Size = new System.Drawing.Size(73, 20);
            this.lb_serialNo.TabIndex = 5;
            this.lb_serialNo.Text = "Serial No";
            // 
            // lb_seatCapacity
            // 
            this.lb_seatCapacity.AutoSize = true;
            this.lb_seatCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_seatCapacity.Location = new System.Drawing.Point(11, 88);
            this.lb_seatCapacity.Name = "lb_seatCapacity";
            this.lb_seatCapacity.Size = new System.Drawing.Size(108, 20);
            this.lb_seatCapacity.TabIndex = 6;
            this.lb_seatCapacity.Text = "Seat Capacity";
            // 
            // btn_confirmFlight
            // 
            this.btn_confirmFlight.AutoSize = true;
            this.btn_confirmFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_confirmFlight.Location = new System.Drawing.Point(462, 78);
            this.btn_confirmFlight.Name = "btn_confirmFlight";
            this.btn_confirmFlight.Size = new System.Drawing.Size(96, 37);
            this.btn_confirmFlight.TabIndex = 20;
            this.btn_confirmFlight.Text = "Confirm";
            this.btn_confirmFlight.UseVisualStyleBackColor = true;
            this.btn_confirmFlight.Click += new System.EventHandler(this.btn_confirmFlight_Click);
            // 
            // lb_seatInfo
            // 
            this.lb_seatInfo.AutoSize = true;
            this.lb_seatInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_seatInfo.Location = new System.Drawing.Point(353, 91);
            this.lb_seatInfo.Name = "lb_seatInfo";
            this.lb_seatInfo.Size = new System.Drawing.Size(54, 13);
            this.lb_seatInfo.TabIndex = 21;
            this.lb_seatInfo.Text = "1 < x > 50";
            // 
            // dgv_planes
            // 
            this.dgv_planes.AllowUserToAddRows = false;
            this.dgv_planes.AllowUserToDeleteRows = false;
            this.dgv_planes.AllowUserToResizeColumns = false;
            this.dgv_planes.AllowUserToResizeRows = false;
            this.dgv_planes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_planes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_planes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.airline,
            this.serialNo,
            this.seatCapacity});
            this.dgv_planes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_planes.Location = new System.Drawing.Point(0, 133);
            this.dgv_planes.Name = "dgv_planes";
            this.dgv_planes.ReadOnly = true;
            this.dgv_planes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_planes.Size = new System.Drawing.Size(784, 328);
            this.dgv_planes.TabIndex = 22;
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // airline
            // 
            this.airline.HeaderText = "Airline";
            this.airline.Name = "airline";
            this.airline.ReadOnly = true;
            // 
            // serialNo
            // 
            this.serialNo.HeaderText = "Serial No";
            this.serialNo.Name = "serialNo";
            this.serialNo.ReadOnly = true;
            // 
            // seatCapacity
            // 
            this.seatCapacity.HeaderText = "Seat Capacity";
            this.seatCapacity.Name = "seatCapacity";
            this.seatCapacity.ReadOnly = true;
            // 
            // AC_Plane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_planes);
            this.Controls.Add(this.lb_seatInfo);
            this.Controls.Add(this.btn_confirmFlight);
            this.Controls.Add(this.lb_seatCapacity);
            this.Controls.Add(this.lb_serialNo);
            this.Controls.Add(this.tb_serialNo);
            this.Controls.Add(this.tb_seatCapacity);
            this.Controls.Add(this.tb_airline);
            this.Controls.Add(this.lb_airline);
            this.Name = "AC_Plane";
            this.Size = new System.Drawing.Size(784, 461);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_planes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_airline;
        private System.Windows.Forms.TextBox tb_airline;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox tb_seatCapacity;
        private System.Windows.Forms.TextBox tb_serialNo;
        private System.Windows.Forms.Label lb_serialNo;
        private System.Windows.Forms.Label lb_seatCapacity;
        private System.Windows.Forms.Button btn_confirmFlight;
        private System.Windows.Forms.Label lb_seatInfo;
        private System.Windows.Forms.DataGridView dgv_planes;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn airline;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn seatCapacity;
    }
}

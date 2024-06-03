namespace FlightTicketMatic_V2.UserControls
{
    partial class UC_Reservation
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_confirmReservation = new System.Windows.Forms.Button();
            this.lb_totalPayment = new System.Windows.Forms.Label();
            this.tb_securityCode = new System.Windows.Forms.TextBox();
            this.tb_expirationDate = new System.Windows.Forms.TextBox();
            this.tb_cardNo = new System.Windows.Forms.TextBox();
            this.lb_cartNo = new System.Windows.Forms.Label();
            this.lb_expirationDate = new System.Windows.Forms.Label();
            this.tb_cardName = new System.Windows.Forms.TextBox();
            this.lb_cartName = new System.Windows.Forms.Label();
            this.lb_FlightDetails = new System.Windows.Forms.Label();
            this.lb_flightTime = new System.Windows.Forms.Label();
            this.lb_airline = new System.Windows.Forms.Label();
            this.lb_selectedSeatNo = new System.Windows.Forms.Label();
            this.lb_flightTo = new System.Windows.Forms.Label();
            this.lb_flightFrom = new System.Windows.Forms.Label();
            this.lb_planeId = new System.Windows.Forms.Label();
            this.lb_flightDate = new System.Windows.Forms.Label();
            this.lb_flightId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(428, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 33);
            this.label1.TabIndex = 31;
            this.label1.Text = "Payment";
            // 
            // btn_confirmReservation
            // 
            this.btn_confirmReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_confirmReservation.Location = new System.Drawing.Point(434, 379);
            this.btn_confirmReservation.Name = "btn_confirmReservation";
            this.btn_confirmReservation.Size = new System.Drawing.Size(330, 36);
            this.btn_confirmReservation.TabIndex = 30;
            this.btn_confirmReservation.Text = "Complete Purchase";
            this.btn_confirmReservation.UseVisualStyleBackColor = true;
            this.btn_confirmReservation.Click += new System.EventHandler(this.pb_confirmReservation_Click);
            // 
            // lb_totalPayment
            // 
            this.lb_totalPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_totalPayment.Location = new System.Drawing.Point(434, 345);
            this.lb_totalPayment.Name = "lb_totalPayment";
            this.lb_totalPayment.Size = new System.Drawing.Size(330, 20);
            this.lb_totalPayment.TabIndex = 29;
            this.lb_totalPayment.Text = "Total Payment: 00 $";
            this.lb_totalPayment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_securityCode
            // 
            this.tb_securityCode.Location = new System.Drawing.Point(622, 308);
            this.tb_securityCode.Name = "tb_securityCode";
            this.tb_securityCode.Size = new System.Drawing.Size(142, 20);
            this.tb_securityCode.TabIndex = 25;
            // 
            // tb_expirationDate
            // 
            this.tb_expirationDate.Location = new System.Drawing.Point(434, 308);
            this.tb_expirationDate.Name = "tb_expirationDate";
            this.tb_expirationDate.Size = new System.Drawing.Size(154, 20);
            this.tb_expirationDate.TabIndex = 24;
            // 
            // tb_cardNo
            // 
            this.tb_cardNo.Location = new System.Drawing.Point(434, 233);
            this.tb_cardNo.Name = "tb_cardNo";
            this.tb_cardNo.Size = new System.Drawing.Size(330, 20);
            this.tb_cardNo.TabIndex = 23;
            // 
            // lb_cartNo
            // 
            this.lb_cartNo.AutoSize = true;
            this.lb_cartNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_cartNo.Location = new System.Drawing.Point(429, 193);
            this.lb_cartNo.Name = "lb_cartNo";
            this.lb_cartNo.Size = new System.Drawing.Size(258, 25);
            this.lb_cartNo.TabIndex = 28;
            this.lb_cartNo.Text = "Credit/Debit Card Number";
            // 
            // lb_expirationDate
            // 
            this.lb_expirationDate.AutoSize = true;
            this.lb_expirationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_expirationDate.Location = new System.Drawing.Point(429, 268);
            this.lb_expirationDate.Name = "lb_expirationDate";
            this.lb_expirationDate.Size = new System.Drawing.Size(159, 25);
            this.lb_expirationDate.TabIndex = 27;
            this.lb_expirationDate.Text = "Expiration Date";
            // 
            // tb_cardName
            // 
            this.tb_cardName.Location = new System.Drawing.Point(434, 158);
            this.tb_cardName.Name = "tb_cardName";
            this.tb_cardName.Size = new System.Drawing.Size(330, 20);
            this.tb_cardName.TabIndex = 21;
            // 
            // lb_cartName
            // 
            this.lb_cartName.AutoSize = true;
            this.lb_cartName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_cartName.Location = new System.Drawing.Point(429, 118);
            this.lb_cartName.Name = "lb_cartName";
            this.lb_cartName.Size = new System.Drawing.Size(150, 25);
            this.lb_cartName.TabIndex = 26;
            this.lb_cartName.Text = "Name on Card";
            // 
            // lb_FlightDetails
            // 
            this.lb_FlightDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_FlightDetails.Location = new System.Drawing.Point(15, 17);
            this.lb_FlightDetails.Name = "lb_FlightDetails";
            this.lb_FlightDetails.Size = new System.Drawing.Size(309, 33);
            this.lb_FlightDetails.TabIndex = 22;
            this.lb_FlightDetails.Text = "Flight Details";
            // 
            // lb_flightTime
            // 
            this.lb_flightTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_flightTime.Location = new System.Drawing.Point(3, 158);
            this.lb_flightTime.Name = "lb_flightTime";
            this.lb_flightTime.Size = new System.Drawing.Size(309, 20);
            this.lb_flightTime.TabIndex = 39;
            this.lb_flightTime.Text = "Flight Time: ";
            // 
            // lb_airline
            // 
            this.lb_airline.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_airline.Location = new System.Drawing.Point(3, 263);
            this.lb_airline.Name = "lb_airline";
            this.lb_airline.Size = new System.Drawing.Size(309, 20);
            this.lb_airline.TabIndex = 38;
            this.lb_airline.Text = "Airline";
            // 
            // lb_selectedSeatNo
            // 
            this.lb_selectedSeatNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_selectedSeatNo.Location = new System.Drawing.Point(3, 333);
            this.lb_selectedSeatNo.Name = "lb_selectedSeatNo";
            this.lb_selectedSeatNo.Size = new System.Drawing.Size(321, 125);
            this.lb_selectedSeatNo.TabIndex = 37;
            this.lb_selectedSeatNo.Text = "Seat No(s): ";
            // 
            // lb_flightTo
            // 
            this.lb_flightTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_flightTo.Location = new System.Drawing.Point(3, 228);
            this.lb_flightTo.Name = "lb_flightTo";
            this.lb_flightTo.Size = new System.Drawing.Size(309, 20);
            this.lb_flightTo.TabIndex = 36;
            this.lb_flightTo.Text = "To Location";
            // 
            // lb_flightFrom
            // 
            this.lb_flightFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_flightFrom.Location = new System.Drawing.Point(3, 193);
            this.lb_flightFrom.Name = "lb_flightFrom";
            this.lb_flightFrom.Size = new System.Drawing.Size(309, 20);
            this.lb_flightFrom.TabIndex = 35;
            this.lb_flightFrom.Text = "From Location:";
            // 
            // lb_planeId
            // 
            this.lb_planeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_planeId.Location = new System.Drawing.Point(3, 298);
            this.lb_planeId.Name = "lb_planeId";
            this.lb_planeId.Size = new System.Drawing.Size(309, 20);
            this.lb_planeId.TabIndex = 34;
            this.lb_planeId.Text = "Plane Id:";
            // 
            // lb_flightDate
            // 
            this.lb_flightDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_flightDate.Location = new System.Drawing.Point(3, 123);
            this.lb_flightDate.Name = "lb_flightDate";
            this.lb_flightDate.Size = new System.Drawing.Size(309, 20);
            this.lb_flightDate.TabIndex = 33;
            this.lb_flightDate.Text = "Flight Date: ";
            // 
            // lb_flightId
            // 
            this.lb_flightId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_flightId.Location = new System.Drawing.Point(3, 87);
            this.lb_flightId.Name = "lb_flightId";
            this.lb_flightId.Size = new System.Drawing.Size(309, 21);
            this.lb_flightId.TabIndex = 32;
            this.lb_flightId.Text = "Flight Id: ";
            // 
            // UC_Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lb_flightTime);
            this.Controls.Add(this.lb_airline);
            this.Controls.Add(this.lb_selectedSeatNo);
            this.Controls.Add(this.lb_flightTo);
            this.Controls.Add(this.lb_flightFrom);
            this.Controls.Add(this.lb_planeId);
            this.Controls.Add(this.lb_flightDate);
            this.Controls.Add(this.lb_flightId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_confirmReservation);
            this.Controls.Add(this.lb_totalPayment);
            this.Controls.Add(this.tb_securityCode);
            this.Controls.Add(this.tb_expirationDate);
            this.Controls.Add(this.tb_cardNo);
            this.Controls.Add(this.lb_cartNo);
            this.Controls.Add(this.lb_expirationDate);
            this.Controls.Add(this.tb_cardName);
            this.Controls.Add(this.lb_cartName);
            this.Controls.Add(this.lb_FlightDetails);
            this.Name = "UC_Reservation";
            this.Size = new System.Drawing.Size(784, 461);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_confirmReservation;
        private System.Windows.Forms.Label lb_totalPayment;
        private System.Windows.Forms.TextBox tb_securityCode;
        private System.Windows.Forms.TextBox tb_expirationDate;
        private System.Windows.Forms.TextBox tb_cardNo;
        private System.Windows.Forms.Label lb_cartNo;
        private System.Windows.Forms.Label lb_expirationDate;
        private System.Windows.Forms.TextBox tb_cardName;
        private System.Windows.Forms.Label lb_cartName;
        private System.Windows.Forms.Label lb_FlightDetails;
        private System.Windows.Forms.Label lb_flightTime;
        private System.Windows.Forms.Label lb_airline;
        private System.Windows.Forms.Label lb_selectedSeatNo;
        private System.Windows.Forms.Label lb_flightTo;
        private System.Windows.Forms.Label lb_flightFrom;
        private System.Windows.Forms.Label lb_planeId;
        private System.Windows.Forms.Label lb_flightDate;
        private System.Windows.Forms.Label lb_flightId;
    }
}

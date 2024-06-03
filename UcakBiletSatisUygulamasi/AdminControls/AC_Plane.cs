using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using FlightTicketMatic_V2.UserControls;
using FlightTicketMatic_V2.Service;
using FlightTicketMatic_V2.Models;

namespace FlightTicketMatic_V2.AdminControls
{
    public partial class AC_Plane : UserControl
    {
        DbService _dbService = new DbService();
        private static string connectionString = "Data Source=..\\..\\Data\\FlightTicketMaticDb.db;Version=3;";
        private static AC_Plane _instance;
        public static AC_Plane Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new AC_Plane();
                }
                return _instance;
            }
        }
        public AC_Plane()
        {
            InitializeComponent();
            ListPlanes();
        }

        private void tb_seatCapacity_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            // Check if the key pressed is a control key, a digit, or a decimal point
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                return;
            }

            // Only allow one decimal point
            if ((e.KeyChar == '.') && (textBox.Text.IndexOf('.') > -1))
            {
                e.Handled = true;
                return;
            }

            // Allow input only if the value is less than or equal to 50
            string newText = textBox.Text.Insert(textBox.SelectionStart, e.KeyChar.ToString());

            if (decimal.TryParse(newText, out decimal newValue))
            {
                if (newValue > 50)
                {
                    e.Handled = true;
                }
            }
        }

        private void btn_confirmFlight_Click(object sender, EventArgs e)
        {
            string airline = tb_airline.Text;
            string serialNo = tb_serialNo.Text;
            string seatCapacity = tb_seatCapacity.Text;

            if (string.IsNullOrEmpty(airline) || string.IsNullOrEmpty(serialNo) || string.IsNullOrEmpty(seatCapacity))
            {
                MessageBox.Show("Please fill all fields");
                return;
            }

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                // Check if a plane with the same airline and serial number already exists
                string checkQuery = $@"
                    SELECT COUNT(*)
                    FROM Planes
                    WHERE airline = '{airline}'
                      AND serialNo = '{serialNo}';";

                using (var command = new SQLiteCommand(checkQuery, connection))
                {
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    if (count > 0)
                    {
                        MessageBox.Show("A plane with these details already exists.");
                        return;
                    }
                }

                // Insert the new plane if it does not already exist
                string insertReservationQuery = $@"
                    INSERT INTO Planes (airline, serialNo, seatCapacity) 
                    VALUES ('{airline}', '{serialNo}', {seatCapacity});";

                using (var command = new SQLiteCommand(insertReservationQuery, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Plane added successfully!");
            ListPlanes();
        }

        public async void ListPlanes()
        {
            dgv_planes.Rows.Clear();
            var planes = await _dbService.GetAll<Plane>();
            foreach (var plane in planes)
            {
                dgv_planes.Rows.Add(plane.id, plane.airline, plane.serialNo, plane.seatCapacity);
            }
        }
    }
}

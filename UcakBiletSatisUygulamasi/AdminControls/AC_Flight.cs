using FlightTicketMatic_V2.Models;
using FlightTicketMatic_V2.Service;
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

namespace FlightTicketMatic_V2.AdminControls
{
    public partial class AC_Flight : UserControl
    {
        private static string connectionString = "Data Source=..\\..\\Data\\FlightTicketMaticDb.db;Version=3;";
        DbService _dbService = new DbService();
        private static AC_Flight _instance;
        public static AC_Flight Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new AC_Flight();
                }
                return _instance;
            }
        }
        
        public AC_Flight()
        {
            InitializeComponent();
            GetPlaneIds();
            ListFlights();
        }

        private async void GetPlaneIds()
        {
            var planeId = await _dbService.GetAllIds<Plane>();
            cb_planeId.DataSource = planeId;
            cb_planeId.SelectedIndex = -1;
        }

        private void btn_confirmFlight_Click(object sender, EventArgs e)
        {
            string from = tb_from.Text;
            string to = tb_to.Text;
            string departureDate = dtp_departureDate.Value.ToString("dd-MM-yyyy");
            string departureTime = dtp_departureTime.Value.ToString("HH:mm");
            string planeId = cb_planeId.SelectedItem?.ToString() ?? "";

            if (string.IsNullOrEmpty(from) || string.IsNullOrEmpty(to) || string.IsNullOrEmpty(departureDate) || string.IsNullOrEmpty(departureTime) || string.IsNullOrEmpty(planeId))
            {
                MessageBox.Show("Please fill all fields");
                return;
            }

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                // Check if a flight with the same details already exists
                string checkQuery = $@"
                    SELECT COUNT(*) 
                    FROM Flights 
                    WHERE fromLocation = '{from}' 
                      AND toLocation = '{to}' 
                      AND departureDate = '{departureDate}' 
                      AND departureTime = '{departureTime}' 
                      AND planeId = {planeId};";

                using (var command = new SQLiteCommand(checkQuery, connection))
                {
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    if (count > 0)
                    {
                        MessageBox.Show("A flight with these details already exists.");
                        return;
                    }
                }

                // Insert the new flight if it does not already exist
                string insertReservationQuery = $@"
                    INSERT INTO Flights(fromLocation, toLocation, departureDate, departureTime, planeId) 
                    VALUES('{from}', '{to}', '{departureDate}', '{departureTime}', {planeId});";

                using (var command = new SQLiteCommand(insertReservationQuery, connection))
                {
                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Flight added successfully!");
            ListFlights();
        }

        private void tb_from_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122) || e.KeyChar == 8 || e.KeyChar == 32))
            {
                e.Handled = true;
            }
        }

        private void tb_to_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122) || e.KeyChar == 8 || e.KeyChar == 32))
            {
                e.Handled = true;
            }
        }

        public async void ListFlights()
        {
            dgv_flights.Rows.Clear();
            var flights = await _dbService.GetAll<Flight>();
            foreach (var flight in flights)
            {
                dgv_flights.Rows.Add(flight.id, flight.fromLocation, flight.toLocation, flight.departureDate, flight.departureTime, flight.planeId);
            }
        }
    }
}

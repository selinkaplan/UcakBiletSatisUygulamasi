using FlightTicketMatic_V2.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using FlightTicketMatic_V2.Models;

namespace FlightTicketMatic_V2.UserControls
{
    public partial class UC_Reservation : UserControl
    {
        DbService _dbService = new DbService();
        private static string connectionString = "Data Source=..\\..\\Data\\FlightTicketMaticDb.db;Version=3;";
        private List<string> selectedSeats;
        private int userId;
        private int flightId;

        public void GetSelectedSeats(List<string> selected_seats)
        {
            selectedSeats = selected_seats;
        }
        public void GetUserId(int user_id)
        {
            userId = user_id;
        }
        public void GetFlightId(int flight_id)
        {
            flightId = flight_id;
        }
        private static UC_Reservation _instance;
        public static UC_Reservation Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UC_Reservation();
                }
                return _instance;
            }
        }
        public UC_Reservation()
        {
            InitializeComponent();
        }
        private void ClearReservationLabels()
        {
            lb_flightId.Text = "Flight Id: ";
            lb_flightDate.Text = "Flight Date: ";
            lb_flightTime.Text = "Flight Time: ";
            lb_flightFrom.Text = "From Location: ";
            lb_flightTo.Text = "To Location: ";
            lb_airline.Text = "Airline: ";
            lb_planeId.Text = "Plane Id: ";
            lb_selectedSeatNo.Text = "Seat No(s): ";
            lb_totalPayment.Text = "Total Payment: 00 $";
        }
        public void ReservationDetails(int selectedFlight, List<string> selectedSeats)
        {
            ClearReservationLabels();
            if (selectedFlight == 0 && selectedSeats == null)
            {
                return;
            }

            var selectedFlightDetails = _dbService.GetEntityById<Flight>(selectedFlight);
            var selectedPlaneDetails = _dbService.GetEntityById<Plane>(selectedFlightDetails.planeId);

            lb_flightId.Text += $"{selectedFlightDetails.id.ToString(CultureInfo.InvariantCulture)}";
            lb_flightDate.Text += $"{selectedFlightDetails.departureDate}";
            lb_flightTime.Text += $"{selectedFlightDetails.departureTime}";
            lb_flightFrom.Text += $"{selectedFlightDetails.fromLocation}";
            lb_flightTo.Text += $"{selectedFlightDetails.toLocation}";
            lb_airline.Text += $"{selectedPlaneDetails.airline}";
            lb_planeId.Text += $"{selectedFlightDetails.planeId.ToString()}";


            selectedSeats.Sort();
            foreach (string selectedSeat in selectedSeats)
            {
                lb_selectedSeatNo.Text += $"{selectedSeat}, ";
            }
            lb_totalPayment.Text = "Total Payment: ";
            lb_totalPayment.Text += $"{(Convert.ToInt32(selectedSeats.Count()) * 10.00).ToString()}";
            lb_totalPayment.Text += " $";
        }

        private void pb_confirmReservation_Click(object sender, EventArgs e)
        {
            if (flightId == 0 || selectedSeats == null)
            {
                MessageBox.Show("Before purchasing a ticket, please select a movie session.");
                return;
            }
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                Reservation reservation = _dbService.GetReservedSeatsNoBasedOnFlightId(flightId);


                foreach (var seat in selectedSeats)
                {
                    string insertReservationQuery = $@"
                    INSERT INTO Reservations (seatNo, flightId, userId) VALUES ('{seat}', {flightId}, {userId});";

                    using (var command = new SQLiteCommand(insertReservationQuery, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }

            MessageBox.Show("Thank you for your purchase! Enjoy the show!");
            GetFlightId(0);
            GetSelectedSeats(null);
            ReservationDetails(0, null);
            UC_Location.Instance.ListFlights(null, null);
            UC_Seat.Instance.GetFlight(0);
            ((FlightTicketMatic)this.ParentForm).tab_Home_Click(null, null);
        }
    }
}

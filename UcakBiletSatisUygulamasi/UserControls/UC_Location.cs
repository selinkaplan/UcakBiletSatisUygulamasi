using FlightTicketMatic_V2.Service;
using System;
using System.Linq;
using System.Windows.Forms;
using FlightTicketMatic_V2.Models;

namespace FlightTicketMatic_V2.UserControls
{
    public partial class UC_Location : UserControl
    {
        DbService _dbService = new DbService();
        private static UC_Location _instance;
        public static UC_Location Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UC_Location();
                }
                return _instance;
            }
        }
        public UC_Location()
        {
            InitializeComponent();
            GetFromLocations();
        }

        private async void GetFromLocations()
        {
            var from = await _dbService.GetAll<Flight>();
            var distinctFroms = from.Select(f => f.fromLocation).Distinct().ToList();
            cb_from.DataSource = distinctFroms;
            cb_from.SelectedIndex = -1;
        }

        private async void GetToLocations()
        {
            if (cb_from.SelectedItem.ToString() == null)
                return;

            var to = await _dbService.GetToByFrom(cb_from.SelectedItem.ToString());
            cb_to.DataSource = to;
        }

        public async void ListFlights(string? selected_from, string? selected_to)
        {
            if (selected_from == null || selected_to == null)
                return;
            dgv_flights.Rows.Clear();
            var flights = await _dbService.GetFlight(selected_from, selected_to);
            foreach (var flight in flights)
            {
                dgv_flights.Rows.Add(flight.id, flight.fromLocation, flight.toLocation, flight.departureDate, flight.departureTime, flight.planeId);
            }
        }

        private void cb_from_DropDownClosed(object sender, EventArgs e)
        {
            if (cb_from.SelectedIndex == -1 || cb_from.SelectedItem == null)
                return;

            GetToLocations();
            ListFlights(cb_from.SelectedItem.ToString(), cb_to.SelectedItem.ToString());
        }

        private void cb_to_DropDownClosed(object sender, EventArgs e)
        {
            if (cb_to.SelectedIndex == -1 || cb_to.SelectedItem == null)
                return;

            ListFlights(cb_from.SelectedItem.ToString(), cb_to.SelectedItem.ToString());
        }

        private void dgv_flights_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idColumnIndex = 0;
            int ClickedRowIndex = e.RowIndex;
            DataGridViewRow selectedRow = dgv_flights.Rows[ClickedRowIndex];

            if (selectedRow.Cells[idColumnIndex].Value != null)
            {
                int selected_flight = Convert.ToInt32(selectedRow.Cells[idColumnIndex].Value);

                UC_Seat.Instance.GetFlight(selected_flight);
                UC_Reservation.Instance.GetFlightId(selected_flight);
                ((FlightTicketMatic)this.ParentForm).tab_Seat_Click(null, null);
            }
        }
    }
}

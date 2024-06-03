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

namespace FlightTicketMatic_V2.UserControls
{
    public partial class UC_Seat : UserControl
    {
        DbService _dbService = new DbService();
        List<string> selectedSeats = new List<string>();
        List<string> occupiedSeats = new List<string>();
        private int selectedFlightId;
        public void SetSelectedFlightId(int id)
        {
            selectedFlightId = id;
        }
        private static UC_Seat _instance;
        public static UC_Seat Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UC_Seat();
                }
                return _instance;
            }
        }
        public UC_Seat()
        {
            InitializeComponent();
        }

        private void ClearTheaterSeats()
        {
            foreach (Control control in Controls.OfType<Button>().ToList())
            {
                Controls.Remove(control);
                control.Dispose();
            }
        }
        public void GetFlight(int selectedFlight)
        {
            ClearTheaterSeats();
            selectedSeats.Clear();
            if (selectedFlight == 0)
            {
                lb_selectedSeats.Text = "Selected Seat(s):";
                return;
            }
            occupiedSeats = _dbService.GetOccupiedSeatsNoBasedOnFlightId(selectedFlight);
            CreateSeats(10, 6, occupiedSeats);
            Instance.SetSelectedFlightId(selectedFlight);
        }
        private void CreateSeats(int rowCount, int columnCount, List<string> occupiedSeats)
        {
            const int seatGap = 5;
            const int seatWidth = 30;
            const int seatHeight = 30;
            const int aisleGap = 20;

            char[] letters = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            int totalWidth = columnCount * (seatWidth + seatGap) + aisleGap;
            int totalHeight = rowCount * (seatHeight + seatGap);
            int startX = 10;
            int startY = ((ClientSize.Height - totalHeight) / 2) - 30 ;

            for (int row = 0; row < rowCount; row++)
            {
                for (int col = 0; col < columnCount; col++)
                {
                    Button btnSeat = new Button();
                    btnSeat.Cursor = Cursors.Hand;
                    btnSeat.Name = $"btnSeat_{letters[row]}{col + 1}";
                    btnSeat.Text = $"{letters[row]}{col + 1}";

                    if (occupiedSeats.Contains(btnSeat.Text))
                    {
                        btnSeat.BackColor = Color.Red;
                        btnSeat.ForeColor = Color.Black;
                    }
                    else if (selectedSeats.Contains(btnSeat.Text))
                    {
                        btnSeat.BackColor = Color.Green;
                        btnSeat.ForeColor = Color.Black;
                    }

                    btnSeat.Width = seatWidth;
                    btnSeat.Height = seatHeight;

                    if (col >= columnCount / 2)
                    {
                        btnSeat.Left = startX + col * (seatWidth + seatGap) + aisleGap;
                    }
                    else
                    {
                        btnSeat.Left = startX + col * (seatWidth + seatGap);
                    }

                    btnSeat.Top = startY + row * (seatHeight + seatGap);

                    btnSeat.Click += BtnSeat_Click;
                    Controls.Add(btnSeat);
                }
            }
        }

        private void BtnSeat_Click(object sender, EventArgs e)
        {
            string seatName = ((Button)sender).Name;
            string seatNumber = seatName.Substring(seatName.IndexOf('_') + 1);

            if (selectedSeats.Contains(seatNumber))
            {
                selectedSeats.Remove(seatNumber);
            }
            else if (occupiedSeats.Contains(seatNumber))
            {
                MessageBox.Show("This seat already taken!");
                return;
            }
            else
            {
                selectedSeats.Add(seatNumber);
            }

            if (selectedSeats.Contains(seatNumber))
            {
                ((Button)sender).BackColor = Color.Green;
            }
            else
            {
                ((Button)sender).BackColor = Color.White;
            }

            selectedSeats.Sort();

            lb_selectedSeats.Text = "Selected Seats: ";

            foreach (string selectedSeat in selectedSeats)
            {
                lb_selectedSeats.Text += selectedSeat + ", ";
            }
        }

        private void pb_confirmSeats_Click(object sender, EventArgs e)
        {
            if (selectedSeats.Count == 0)
            {
                MessageBox.Show("Select a seat first!");
                return;
            }

            UC_Reservation.Instance.ReservationDetails(selectedFlightId, selectedSeats);
            UC_Reservation.Instance.GetSelectedSeats(selectedSeats);
            ((FlightTicketMatic)this.ParentForm).tab_Reservation_Click(null, null);
        }
    }
}

using FlightTicketMatic_V2.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightTicketMatic_V2
{
    public partial class FlightTicketMatic : Form
    {
        public FlightTicketMatic()
        {
            InitializeComponent();

            UC_Home uc = new UC_Home();
            addUserControl(uc);

            lb_userName.Text = Login.userName ?? Register.userName ?? "Guest";
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnl_container.Controls.Clear();
            pnl_container.Controls.Add(userControl);
            userControl.BringToFront();
        }

        public void tab_Home_Click(object sender, EventArgs e)
        {
            if (!pnl_container.Controls.Contains(UC_Home.Instance))
            {
                pnl_container.Controls.Add(UC_Home.Instance);
                UC_Home.Instance.Dock = DockStyle.Fill;
                UC_Home.Instance.BringToFront();
            }
            else
            {
                UC_Home.Instance.BringToFront();
            }
        }
        public void tab_Location_Click(object sender, EventArgs e)
        {
            if (!pnl_container.Controls.Contains(UC_Location.Instance))
            {
                pnl_container.Controls.Add(UC_Location.Instance);
                UC_Location.Instance.Dock = DockStyle.Fill;
                UC_Location.Instance.BringToFront();
            }
            else
            {
                UC_Location.Instance.BringToFront();
            }
        }

        public void tab_Seat_Click(object sender, EventArgs e)
        {
            if (!pnl_container.Controls.Contains(UC_Seat.Instance))
            {
                pnl_container.Controls.Add(UC_Seat.Instance);
                UC_Seat.Instance.Dock = DockStyle.Fill;
                UC_Seat.Instance.BringToFront();
            }
            else
            {
                UC_Seat.Instance.BringToFront();
            }
        }

        public void tab_Reservation_Click(object sender, EventArgs e)
        {
            if (!pnl_container.Controls.Contains(UC_Reservation.Instance))
            {
                pnl_container.Controls.Add(UC_Reservation.Instance);
                UC_Reservation.Instance.Dock = DockStyle.Fill;
                UC_Reservation.Instance.BringToFront();
            }
            else
            {
                UC_Reservation.Instance.BringToFront();
            }
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Login.userName = Register.userName = null;
            new Login().Show();
            this.Hide();
        }
    }
}

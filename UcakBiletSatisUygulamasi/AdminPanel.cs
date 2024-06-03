using FlightTicketMatic_V2.AdminControls;
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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();

            AC_Home uc = new AC_Home();
            addUserControl(uc);

            lb_adminName.Text =  AdminLogin.adminName ?? "Guest";
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnl_container.Controls.Clear();
            pnl_container.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void tab_home_Click(object sender, EventArgs e)
        {
            if (!pnl_container.Controls.Contains(AC_Home.Instance))
            {
                pnl_container.Controls.Add(AC_Home.Instance);
                AC_Home.Instance.Dock = DockStyle.Fill;
                AC_Home.Instance.BringToFront();
            }
            else
            {
                AC_Home.Instance.BringToFront();
            }
        }

        private void tab_plane_Click(object sender, EventArgs e)
        {
            if (!pnl_container.Controls.Contains(AC_Plane.Instance))
            {
                pnl_container.Controls.Add(AC_Plane.Instance);
                AC_Plane.Instance.Dock = DockStyle.Fill;
                AC_Plane.Instance.BringToFront();
            }
            else
            {
                AC_Plane.Instance.BringToFront();
            }
        }

        private void tab_flight_Click(object sender, EventArgs e)
        {
            if (!pnl_container.Controls.Contains(AC_Flight.Instance))
            {
                pnl_container.Controls.Add(AC_Flight.Instance);
                AC_Flight.Instance.Dock = DockStyle.Fill;
                AC_Flight.Instance.BringToFront();
            }
            else
            {
                AC_Flight.Instance.BringToFront();
            }
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            AdminLogin.adminName = null;
            new AdminLogin().Show();
            this.Hide();
        }
    }
}

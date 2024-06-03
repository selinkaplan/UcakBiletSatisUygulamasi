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

namespace FlightTicketMatic_V2.AdminControls
{
    public partial class AC_Home : UserControl
    {
        private static AC_Home _instance;
        public static AC_Home Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new AC_Home();
                }
                return _instance;
            }
        }
        public AC_Home()
        {
            InitializeComponent();
        }
    }
}

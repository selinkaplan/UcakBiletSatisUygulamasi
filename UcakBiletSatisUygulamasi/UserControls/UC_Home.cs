﻿using System;
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
    public partial class UC_Home : UserControl
    {
        private static UC_Home _instance;
        public static UC_Home Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UC_Home();
                }
                return _instance;
            }
        }
        public UC_Home()
        {
            InitializeComponent();
        }

        private void btn_buyTicket_Click(object sender, EventArgs e)
        {
            ((FlightTicketMatic)this.ParentForm).tab_Location_Click(null, null);
        }
    }
}

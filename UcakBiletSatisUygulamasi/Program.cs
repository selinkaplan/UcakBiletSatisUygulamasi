using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketMatic_V2;

namespace FlightTicketMatic_V2
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //
            DbInitializer.InitializeDatabase();
            //

            Application.Run(new Login());
            //Application.Run(new FlightTicketMatic());
        }
    }
}

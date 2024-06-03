using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightTicketMatic_V2.Models
{
    public class Reservation
    {
        public int id { get; set; }
        public string seatNo { get; set; }

        // Relationships
        public int flightId { get; set; }
        public int userId { get; set; }
    }
}

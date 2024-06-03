using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightTicketMatic_V2.Models
{
    public class Plane
    {
        public int id { get; set; }
        public string airline { get; set; }
        public string serialNo { get; set; }
        public int seatCapacity { get; set; }
    }
}

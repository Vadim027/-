using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Управление_самолетами.Models
{
    public class AircraftStatus
    {
        public int Id { get; set; }
        public int AircraftId { get; set; }
        public double FlightSpeed { get; set; }
        public double Altitude { get; set; }
        public double ClimbRate { get; set; }
        public string TurnDirection { get; set; } // straight/left/right
        public double TurnSpeed { get; set; }
        public bool Gear { get; set; }
    }
}

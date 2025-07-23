using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Управление_самолетами.Models
{
    public enum TurnDirection
    {
        Straight,
        Left,
        Right
    }

    public class AircraftStatus
    {
        public int Id { get; set; }
        public int AircraftId { get; set; }
        public float FlightSpeed { get; set; }
        public float Altitude { get; set; }
        public float ClimbRate { get; set; }
        public TurnDirection TurnDirection { get; set; }
        public float TurnSpeed { get; set; }
        public bool Gear { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Управление_самолетами.Models
{
    public class Aircraft
    {
        public int Id { get; set; }
        public string SerialNumber { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ManufacturerId { get; set; }
    }
}

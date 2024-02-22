using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirestationSystem.Model
{
    internal class Incidents
    {
        public string Name { get; set; }
        public string Gps { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public List<Truck> DispatchedTrucks { get; set; } = new List<Truck>();
    }
}

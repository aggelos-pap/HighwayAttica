using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace HighwayAttica
{
    internal class Junction
    {
        public int JunctionId { get; set; }
        public int ElectronicTolls { get; set; }
        public int PhysicalTolls { get; set; }
        //public List<Car> Cars { get; set; }
        // Create new toll here?

        ///Junction constructor///
        public Junction(int junctionId, int electronicTolls, int physicalTolls) 
        {
            JunctionId = junctionId;
            ElectronicTolls = electronicTolls;
            PhysicalTolls = physicalTolls;
            //Cars = new List<Car>();
        }

        ///Remove vehicles from entrance by removing vehicles from
        ///tolls. Add random cars on tolls
        
        internal void operate()
        {

        }
    }
}

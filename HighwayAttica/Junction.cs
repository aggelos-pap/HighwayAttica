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
        List<Junction> junctions { get; set; }
        public int VehiclesWaitingForEntry { get; set; }
        public int JunctionId { get; set; }
        public int ElectronicTolls { get; set; }
        int K;
        public int PhysicalTolls { get; set; }
        public int JunctionCap;
        //public List<Car> Cars { get; set; }
        // Create new toll here?

        ///Junction constructor///
        public Junction(int junctionId, int electronicTolls, int physicalTolls, int k, List<Junction> Junctions) 
        {
            this.K = k;
            JunctionId = junctionId;
            ElectronicTolls = electronicTolls;
            PhysicalTolls = physicalTolls;
            JunctionCap = (electronicTolls * 2 * K) + (physicalTolls * K);
            junctions = Junctions;
            //Cars = new List<Car>();
        }


        /// <summary>
        /// Generates vehicles waiting for entry and returns it
        /// </summary>
        /// <returns></returns>
         
        internal int GenerateVehiclesWaitingForEntry(int seed)
        {
            Random fun = new Random(seed);
            int returnCars = fun.Next(1, 10);
            return returnCars;
        }

        ///Remove vehicles from entrance by removing vehicles from
        ///tolls. Add random cars on tolls

        //Not working
        internal void operate()
        {
            // Remove vehicles from entrance tolls
            int vehiclesToLeave = Math.Min(VehiclesWaitingForEntry, PhysicalTolls);
            VehiclesWaitingForEntry -= vehiclesToLeave;

            // Generate a random number of new vehicles
            int seed = (int)DateTime.Now.Ticks;
            int newVehicles = GenerateVehiclesWaitingForEntry(seed);

            // Check if adding new vehicles will exceed the junction capacity
            if (VehiclesWaitingForEntry + newVehicles > JunctionCap)
            {
                // If it exceeds, adjust the number of new vehicles to the remaining capacity
                newVehicles = JunctionCap - VehiclesWaitingForEntry;
            }

            // Add new vehicles to the waiting list
            VehiclesWaitingForEntry += newVehicles;
        }
    }
}

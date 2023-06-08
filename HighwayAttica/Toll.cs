using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighwayAttica
{
    internal class Toll
    {
        public int VehiclesWaitingForEntry { get; set; }

        public Toll( int vehiclesWaitinForEntry) 
        {
            VehiclesWaitingForEntry = vehiclesWaitinForEntry;
        }

        /// <summary>
        /// Generates initial cars at tolls
        /// Then it adds vehicles on tolls. 
        /// Afterwards remove vehicles on tolls.???
        /// </summary>
        internal void GenerateInitialVehiclesRandomly() 
        { }

    }
}

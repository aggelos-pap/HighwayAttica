using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighwayAttica
{
    internal class Highway
    {
        public int NSegs { get; set; }
        

        ///<summary>
        /// Highway constructor
        /// </summary>
        public Highway(int nsegs) 
        {
            this.NSegs = nsegs;
            Console.WriteLine("Αυτοκινητόδρομος σε λειτουργία.");
        }

        public int TotalVehiclesInHighway()
        {
/*            int TotalCapacity = 0;
            foreach (Segment in segment){
                Segment.capacity += TotalCapacity;
            }*/
            //TotalCapacity
            return 0;
        }

        /// <summary>
        /// The functionality of operate is a circle of operations of the highway
        /// segments. The segments work sequentially, beggining from the final.
        /// Each time print out the amount of vehicles (TotalVehiclesInHighway?).
        /// </summary>
        public void operate() { }

    }
}

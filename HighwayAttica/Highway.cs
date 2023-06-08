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
        public int TotalVehiclesInHighway { get; set; }
        public List<Segment> Segments { get; set; }



        ///<summary>
        /// Highway constructor
        /// </summary>
        public Highway(int nsegs, List<Segment> segments) 
        {
            this.NSegs = nsegs;
            Segments = segments;
            Console.WriteLine("Αυτοκινητόδρομος σε λειτουργία.");
        }

        

        /// <summary>
        /// The functionality of operate is a circle of operations of the highway
        /// segments. The segments work sequentially, beggining from the final.
        /// Each time print out the amount of vehicles (TotalVehiclesInHighway?).
        /// </summary>
        public void operate() 
        {
            foreach (Segment seg in Segments)
            {
                seg.pass();
                seg.exit();
                seg.enter();

            }
            Console.WriteLine("Vehicles in attica are{0} :", TotalVehiclesInHighway);
        }

    }
}

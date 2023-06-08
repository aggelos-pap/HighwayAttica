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
        
        public List<Vehicle> vehicles { get; set; }
        public List<Segment> segments { get; set; }
        public List<Junction> junctions { get; set; }



        ///<summary>
        /// Highway constructor
        /// </summary>
        public Highway(int nsegs,  List<Vehicle> Vehicles, List<Segment> Segments, List<Junction> Junctions) 
        {
            this.NSegs = nsegs;
            vehicles = Vehicles;
            segments = Segments;
            junctions = Junctions;
            Console.WriteLine("Αυτοκινητόδρομος σε λειτουργία.");
        }

        

        /// <summary>
        /// The functionality of operate is a circle of operations of the highway
        /// segments. The segments work sequentially, beggining from the final.
        /// Each time print out the amount of vehicles (TotalVehiclesInHighway?).
        /// </summary>
        /// 
        //Not working
        public void operate() 
        {
            int v1 = 0;
            int v2 = 0;
            int v3 = 0;
            foreach (Segment seg in segments)
            {
                
                seg.exit(vehicles);
                foreach (Segment seg2 in segments)
                {
                    v1 += seg2.get_no_of_vehicles();
                    break;
                    
                }
                Console.WriteLine("Number of vehicles is {0}:", v1);
                    seg.pass(vehicles);
                foreach (Segment seg2 in segments)
                {
                    v2 += seg2.get_no_of_vehicles();
                    break;
                }
                Console.WriteLine("Number of vehicles is {0}:", v2);
                seg.enter(vehicles);
                
                foreach (Segment seg2 in segments)
                {
                    v3 += seg2.get_no_of_vehicles();
                    break;
                }
                Console.WriteLine("Number of vehicles is {0}:", v3);
            }
            
        }

    }
}

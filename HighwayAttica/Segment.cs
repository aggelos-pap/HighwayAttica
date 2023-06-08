using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighwayAttica
{
    internal class Segment
    {
        
        public int TotalVehiclesInSegment { get; set; }
        public int SegmentCapacity { get; set; }
        public bool NextSegment { get; set; }
        public bool PrevSegment { get; set; }
        public int SegmentId { get; set; }
        public int N { get; set; }
        public List<Vehicle> Vehicles { get; set; }
        public List<Segment> Segments { get; set; }
        public Segment(int segmentId, int segmentCapacity, int totalVehiclesInSegment, int n, List<Vehicle> vehicles, List<Segment> segments) 
        {
            
            this.N = n;
            this.SegmentId = segmentId;
            this.SegmentCapacity = segmentCapacity;
            this.TotalVehiclesInSegment = totalVehiclesInSegment;
            Vehicles = vehicles;
            Segments = segments;
            if (this.SegmentId == 0) 
            { PrevSegment = false;
                NextSegment = true;
            }
            else if (this.SegmentId == N-1)
            {
                NextSegment = false;
                PrevSegment = true; 
            } 
            else 
            {
                PrevSegment = true;
                NextSegment = true; 
            }
        }


        /// <summary>
        ///Segment entrance
        /// </summary>
        public void segmentEntrance()
        {
            foreach (Segment seg in Segments)
            {
                Console.WriteLine("Segment id: {0}, Capacity: {1}, Total Vehicles: {2}", seg.SegmentId, seg.SegmentCapacity, seg.TotalVehiclesInSegment);
            }
            
        }






        /// <summary>
        ///Enter vehicles in segment when possible
        /// </summary>
        public void enter() 
        { 
        }

        /// <summary>
        ///Removes vehicles from highway when possible <summary>
        /// Removes vehicles from highway when possible
        /// </summary>
        public void exit() 
        {
            for (int i = Vehicles.Count - 1; i >= 0; i--)
            {
                if (Vehicles[i].ReadyToExitFromSegment)
                {
                    Vehicles.RemoveAt(i);
                }
            }

        }

        /// <summary>
        ///Remove vehicle from segment and move to the next segment 
        ///when possible.
        /// </summary>
        public void pass() 
        { }

        /// <summary>
        ///Returns number of vehicles in segment
        /// </summary>
        public int get_no_of_vehicles()
        {
            return TotalVehiclesInSegment;
        }

        /// <summary>
        /// It works by changing the amount of vehicles that move on segment.
        /// In case capacity is not enough and vehicles cant all pass to the
        /// next segment, the choice of vehiles that will pass is generated randomly.
        /// Also, during the change of vehicles, incoming vehicles are removed from
        /// the entrance. During the operation, print the relevant messages.
        /// Finally some random vehicles are getting ready to exit the segment.
        /// </summary>
        public void operate() 
        {
        }






    }
}

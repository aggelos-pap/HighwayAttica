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
        public Segment(int segmentId, int segmentCapacity, int totalVehiclesInSegment, int n) 
        {
            this.N = n;
            this.SegmentId = segmentId;
            this.SegmentCapacity = segmentCapacity;
            this.TotalVehiclesInSegment = totalVehiclesInSegment;
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
        public int get_no_of_vehciles()
        {
            return 0;
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

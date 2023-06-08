using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighwayAttica
{
    internal class Vehicle
    {
        /// <summary>
        /// Segment constructor
        /// </summary>

        public int SegmentIsInId { get; set; }
        public int JunctionExitId { get; set; }
        public bool ReadyToExitFromSegment { get; set; }

        public Vehicle(int segmentIsInId, int junctionExitId, bool readyToExitFromSegment)
        {
            SegmentIsInId = segmentIsInId;
            JunctionExitId = junctionExitId;
            ReadyToExitFromSegment = readyToExitFromSegment;
        }
    }
}

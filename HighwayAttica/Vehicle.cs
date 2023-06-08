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
        public int Id { get; set; }
        public int SegmentIsInId { get; set; }
        public int JunctionExitId { get; set; }
        public bool ReadyToExitFromSegment { get; set; }

        public Vehicle(int id, int segmentIsInId, int junctionExitId, bool readyToExitFromSegment)
        {
            this.Id = id;
            SegmentIsInId = segmentIsInId;
            JunctionExitId = junctionExitId;
            ReadyToExitFromSegment = readyToExitFromSegment;
        }
    }
}

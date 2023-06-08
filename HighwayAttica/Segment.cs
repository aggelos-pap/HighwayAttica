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
        public List<Vehicle> vehicles { get; set; }
        public List<Segment> segments { get; set; }
        public List<Junction> junctions { get; set; }
        public Segment(int segmentId, int segmentCapacity, int totalVehiclesInSegment, int n, List<Vehicle> Vehicles, List<Segment> Segments, List<Junction> Junctions) 
        {
            
            this.N = n;
            this.SegmentId = segmentId;
            this.SegmentCapacity = segmentCapacity;
            this.TotalVehiclesInSegment = totalVehiclesInSegment;
            vehicles = Vehicles;
            segments = Segments;
            junctions = Junctions;
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
            foreach (Segment seg in segments)
            {
                Console.WriteLine("Segment id: {0}, Capacity: {1}, Total Vehicles: {2}", seg.SegmentId, seg.SegmentCapacity, seg.TotalVehiclesInSegment);
            }
            
        }






        /// <summary>
        ///Enter vehicles in segment when possible
        /// </summary>
        public void enter(List<Vehicle> vehicles)
        {
            foreach (Junction jun in junctions)
            {
                int createVeh = jun.VehiclesWaitingForEntry;
                for (int i = 0; i < createVeh; i++)
                {
                    var lastVehId = vehicles.Last().Id;
                    var lastJuncId = jun.JunctionId - 1;
                    Vehicle veh = new Vehicle(lastVehId + 1, lastJuncId, lastJuncId + 1, false);
                    vehicles.Add(veh);
                }
            }
        }

        /// <summary>
        ///Removes vehicles from highway when possible <summary>
        /// Removes vehicles from highway when possible
        /// </summary>
        public void exit(List<Vehicle> vehicles)
        {
            for (int i = vehicles.Count - 1; i >= 0; i--)
            {
                if (vehicles[i].ReadyToExitFromSegment)
                {
                  // Vehicles.RemoveAt(i);
                    vehicles.RemoveAt(i); // Remove the vehicle from the vehicles list in Program class
                }
            }
        }

        /// <summary>
        ///Remove vehicle from segment and move to the next segment 
        ///when possible.
        /// </summary>
        /// <summary>
        /// Remove vehicle from segment and move to the next segment 
        /// when possible.
        /// </summary>
        /// <summary>
        /// Remove vehicle from segment and move to the next segment 
        /// when possible.
        /// </summary>
        public void pass(List<Vehicle> vehicles)
        {
            for (int i = vehicles.Count - 1; i >= 0; i--)
            {
                Vehicle vehicle = vehicles[i];
                int nextSegmentId = SegmentId + 1;

                // Check if the vehicle should exit at the end of the highway
                if (nextSegmentId >= N)
                {
                    exit(vehicles);
                    break;
                }

                Segment nextSegment = segments[nextSegmentId];
                if (nextSegment.TotalVehiclesInSegment < nextSegment.SegmentCapacity)
                {
                    // Move the vehicle to the next segment
                    nextSegment.vehicles.Add(vehicle);
                    nextSegment.TotalVehiclesInSegment++;
                    vehicles.RemoveAt(i);
                    TotalVehiclesInSegment--;

                    // Update the vehicle's segment ID
                    vehicle.SegmentIsInId = nextSegmentId;
                }
            }
        }

        /// <summary>
        ///Returns number of vehicles in segment
        /// </summary>
        public int get_no_of_vehicles()
        {
            return vehicles.Count;
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighwayAttica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // Read N, Nsegs, K, Percent
            int N = int.Parse(args[0]);
            int Nsegs = int.Parse(args[1]);
            int K = int.Parse(args[2]);
            int Percent = int.Parse(args[3]);

            // Segments, Junctions, and vehicles initial creation randomly
            List<Segment> segments = new List<Segment>();
            List<Vehicle> vehicles = new List<Vehicle>();
            List<Junction> junctions = new List<Junction>();

            for (int i = 0; i < Nsegs; i++)
            {
                Console.WriteLine("Enter segment capacity:");
                int cap = int.Parse(Console.ReadLine());
                Segment seg = new Segment(i, cap, 0, Nsegs, vehicles, segments, junctions);
                segments.Add(seg);
            }

            Random elRan = new Random();
            Random phRan = new Random();
            Random random = new Random();
            int l = 0;
            foreach (Segment seg in segments)
            {
                int seed = (int)DateTime.Now.Ticks; // Needed for random generation
                Junction jun = new Junction(seg.SegmentId + 1, elRan.Next(1, 4), phRan.Next(1, 4), K, junctions);
                jun.VehiclesWaitingForEntry = jun.GenerateVehiclesWaitingForEntry(seed);
                junctions.Add(jun);

                int randomSegmentCapacity = random.Next(1, seg.SegmentCapacity);
                int numberOfVehicles = randomSegmentCapacity;
                
                while (numberOfVehicles >= 0)
                {
                    Vehicle veh = new Vehicle(l, seg.SegmentId, -1, false);
                    l++;
                    vehicles.Add(veh);
                    seg.TotalVehiclesInSegment++;
                    numberOfVehicles--;
                }
            }

            // Highway initialization
            Highway attica = new Highway(Nsegs, vehicles, segments, junctions);

            // Adding the amount of vehicles in the highway
           //@@@@@@@@@@@@@@@@@@@@@ Logging
/*            foreach (Vehicle veh in vehicles)
            {
                Console.WriteLine("Vehicle segmentid is {0}, junc is {1}, rte is {2}, id is {3}", veh.SegmentIsInId, veh.JunctionExitId, veh.ReadyToExitFromSegment, veh.Id);
            }*/
            int numberOfVehiclesInHighway = 0;
            foreach (Segment seg in segments)
            {
                numberOfVehiclesInHighway += seg.get_no_of_vehicles();
            }
            attica.TotalVehiclesInHighway = numberOfVehiclesInHighway;

           // Console.WriteLine(vehicles.Count);
            //Console.WriteLine("Hmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmm");

            // Changes cars ready state randomly according to Percent Variable
            // Determine the number of vehicles to set ReadyToExitFromSegment to true
            int numVehiclesToSet = (int)(vehicles.Count * (Percent / 100.0));

            // Shuffle the vehicles list randomly
            Random random2 = new Random();
            vehicles = vehicles.OrderBy(v => random2.Next()).ToList();

            // Set ReadyToExitFromSegment to true for the selected percentage of vehicles
            for (int i = 0; i < numVehiclesToSet; i++)
            {
                vehicles[i].ReadyToExitFromSegment = true;
            }
            for (int m = 0; m < N; m++)
            {
                attica.operate();
            }

            // Print the count of vehicles after the changes
            //Console.WriteLine(vehicles.Count);
            //@@@@@@@@@@@@@@@@@@@@@ Logging
            /*            foreach (Vehicle veh in vehicles)
                        {
                            Console.WriteLine("Vehicle segmentid is {0}, junc is {1}, rte is {2}, id is {3}", veh.SegmentIsInId, veh.JunctionExitId, veh.ReadyToExitFromSegment, veh.Id);
                        }*/
            Console.ReadLine();
        }
    }
}








///                  Logs beyond             ///
///                  


/*  foreach (Junction jun in junctions)
  {
      Console.WriteLine("Junction id: {0}, Electronic tolls: {1}, Physical tolls: {2}, junc capacity {3}", jun.JunctionId, jun.ElectronicTolls, jun.PhysicalTolls, jun.JunctionCap);
  }

  foreach (Vehicle veh in vehicles)
  {
      Console.WriteLine("Vehicle segmentid is {0}, junc is {1}, rte is {2}", veh.SegmentIsInId, veh.JunctionExitId, veh.ReadyToExitFromSegment);
  }

  foreach (Segment seg in segments)
  {
      Console.WriteLine("Segment id: {0}, Capacity: {1}, Total Vehicles: {2}", seg.SegmentId, seg.SegmentCapacity, seg.TotalVehiclesInSegment);
  }*/


/*            foreach (Junction jun in junctions)
{
    Console.WriteLine("Junction id: {0}, Electronic tolls: {1}, Physical tolls: {2}, junc capacity {3}", jun.JunctionId, jun.ElectronicTolls, jun.PhysicalTolls, jun.JunctionCap);
}

foreach (Vehicle veh in vehicles)
{
    Console.WriteLine("Vehicle segmentid is {0}, junc is {1}, rte is {2}", veh.SegmentIsInId, veh.JunctionExitId, veh.ReadyToExitFromSegment);
}

foreach (Segment seg in segments)
{
    Console.WriteLine("Segment id: {0}, Capacity: {1}, Total Vehicles: {2}", seg.SegmentId, seg.SegmentCapacity, seg.TotalVehiclesInSegment);
}*/





/* foreach (Vehicle veh in vehicles)
{
    Console.WriteLine("Vehicle segmentid is {0}, junc is {1}, rte is {2}", veh.SegmentIsInId, veh.JunctionExitId, veh.ReadyToExitFromSegment);
}


          foreach (Segment seg in segments)
            {
                Console.WriteLine(seg.get_no_of_vehciles());
            }*/




/*            foreach (Segment seg in segments)
            {
                Console.WriteLine(seg.get_no_of_vehciles());
            }*/
/*            foreach (Vehicle veh in vehicles)
            {
                Console.WriteLine("Vehicle segmentid is {0}, junc is {1}, rte is {2}", veh.SegmentIsInId, veh.JunctionExitId, veh.ReadyToExitFromSegment);
            }*/



/*   Console.WriteLine("Seg id is: {0}", seg.SegmentId);
   Console.WriteLine("Seg prev is: {0}", seg.NextSegment);
   Console.WriteLine("Seg next is: {0}", seg.PrevSegment);
   Console.WriteLine("Seg N is: {0}", seg.N);*/



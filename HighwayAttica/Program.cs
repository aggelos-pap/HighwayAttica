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
            //10 5 5 30
            //Read N,Nsegs,K,Percent
            int N = int.Parse(args[0]);
            int Nsegs = int.Parse(args[1]);
            int K = int.Parse(args[2]);
            int Percent = int.Parse(args[3]);

            List<Segment> segments = new List<Segment>();

            for (int i = 0; i < Nsegs; i++)
            {
                Console.WriteLine("Enter segment capacity:");
                int cap = int.Parse(Console.ReadLine());
                Segment seg = new Segment(i, cap, 0, Nsegs);
                segments.Add(seg);
            }

            foreach (Segment seg in segments)
            {
                Console.WriteLine("Seg id is: {0}", seg.SegmentId);
                Console.WriteLine("Seg prev is: {0}", seg.NextSegment);
                Console.WriteLine("Seg next is: {0}", seg.PrevSegment);
                Console.WriteLine("Seg N is: {0}", seg.N);
            }

            Console.ReadLine();
        }
    }
}

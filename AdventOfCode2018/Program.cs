using System;

namespace AdventOfCode2018
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            
            Console.WriteLine("Day 1:");
            Console.WriteLine("---");
            Console.Write("1.) ");
            watch.Restart();
            Console.Write(Day1.RunPart1());
            Console.WriteLine(" - " + watch.ElapsedMilliseconds + " ms");
            Console.Write("2.) ");
            watch.Restart();
            Console.Write(Day1.RunPart2());
            Console.WriteLine(" - " + watch.ElapsedMilliseconds + " ms");
            Console.WriteLine("---");
            
            Console.WriteLine("Day 2:");
            Console.WriteLine("---");
            Console.Write("1.) ");
            watch.Restart();
            Console.Write(Day2.RunPart1());
            Console.WriteLine(" - " + watch.ElapsedMilliseconds + " ms");
            Console.Write("2.) ");
            watch.Restart();
            Console.Write(Day2.RunPart2());
            Console.WriteLine(" - " + watch.ElapsedMilliseconds + " ms");
            Console.WriteLine("---");

            /*
            long sum1 = 0;
            long sum2 = 0;
            
            var watch = System.Diagnostics.Stopwatch.StartNew();

            int num = 1000;
            
            for(int i = 0; i < num; ++i)
            {
                watch.Restart();
                Day1.Star1.Run();
                watch.Stop();
                var time1 = watch.ElapsedMilliseconds;
                watch.Restart();
                Day1.Star2.Run();
                watch.Stop();
                var time2 = watch.ElapsedMilliseconds;

                sum1 += time1;
                sum2 += time2;
            }

            Console.WriteLine(sum1 / (float)num);
            Console.WriteLine(sum2 / (float)num);
            */
        }
    }
}
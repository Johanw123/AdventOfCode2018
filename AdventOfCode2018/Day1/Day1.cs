using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2018
{
    static class Day1
    {
        public static string RunPart1()
        {
            var lines = InputHelper.ReadLinesAs<int>("Day1/input.txt");
            return lines.Sum().ToString();
        }
        
        public static string RunPart2()
        {
            var lines = InputHelper.ReadLinesAs<int>("Day1/input.txt");
      
            HashSet<int> hashes = new HashSet<int>();
            int i = 0;
            int sum = 0;

            while(true)
            {
                sum += lines[i];
                if(!hashes.Add(sum))
                {
                    return sum.ToString();
                }
                i = (i + 1) % lines.Count();
            }
        }
    }
}
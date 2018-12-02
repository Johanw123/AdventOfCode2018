using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2018
{
    public static class Day2
    {
        public static string RunPart1()
        {
            var lines = InputHelper.ReadLinesAs<string>("Day2/input.txt");

            Dictionary<char, int> dir = new Dictionary<char, int>();

            int sum1 = 0;
            int sum2 = 0;
            
            foreach (var line in lines)
            {
                foreach (var letter in line)
                {
                    if (dir.ContainsKey(letter))
                        dir[letter]++;
                    else
                        dir.Add(letter, 1);
                }

                if (dir.Values.Contains(2))
                    sum1++;
                if (dir.Values.Contains(3))
                    sum2++;
                
                dir.Clear();
            }

            return (sum1 * sum2).ToString();
        }

        public static string RunPart2()
        {
            var lines = InputHelper.ReadLinesAs<string>("Day2/input.txt");

            foreach (var line in lines)
            {
                foreach (var line2 in lines)
                {
                    if(line == line2) continue;

                    int matching = 0;
                    string result = "";
                    for (int i = 0; i < line.Length; i++)
                    {
                        var char1 = line[i];
                        var char2 = line2[i];

                        if (char1 == char2)
                        {
                            matching++;
                            result += char1;
                        } 
                    }

                    if (matching == line.Length - 1)
                        return result;
                }                
            }

            return "";
        }
    }
}
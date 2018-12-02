using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2018
{
    class InputHelper
    {
        public static IList<T> ReadLinesAs<T>(string filename)
        {
            var lines = File.ReadLines(filename);

            switch (Type.GetTypeCode(typeof(T)))
            {
                case TypeCode.Int32:
                    return lines.Select(int.Parse).ToList() as IList<T>;
                case TypeCode.Single:
                    return lines.Select(float.Parse).ToList() as IList<T>;
                case TypeCode.Decimal:
                    return lines.Select(double.Parse).ToList() as IList<T>;
            }

            return lines.ToList() as IList<T>;
        }
    }
}
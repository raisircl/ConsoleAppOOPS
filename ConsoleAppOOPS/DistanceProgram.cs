using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppOOPS
{
    internal class DistanceProgram
    {
        static void Main()
        {
            Distance d1 = new Distance() { Feet = 5, Inch = 8 };
            Distance d2 = new Distance() { Feet = 6, Inch = 4 };

            Distance d3 = d1 + d2;

            Console.WriteLine($"Distance: {d3.Feet} Feet {d3.Inch} Inch");
        }
    }
}

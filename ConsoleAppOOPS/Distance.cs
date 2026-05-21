using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppOOPS
{
    internal class Distance
    {
        public int Feet { get; set; }
        public int Inch { get; set; }
        public static Distance operator+(Distance d1, Distance d2)
        {
            Distance temp = new Distance();
            temp.Feet = d1.Feet + d2.Feet;   
            temp.Inch = d1.Inch + d2.Inch;   
            return temp;    
        }
    }
}
// Box class l, b, h vol(), check 2 boxex equal or not overload == operator and != operator, overload > and < operator to compare the volume of 2 boxes, overload + operator to add the dimensions of 2 boxes and return a new box with added dimensions.

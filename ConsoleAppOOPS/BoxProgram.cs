using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppOOPS
{
    internal class BoxProgram
    {
        static void Main()
        {
            Box b1 = new Box(); // default constructor
            Box b2 = new Box(2, 3, 4); // parameterized constructor
            Box b3 = new Box(b2); // copy constructor
            Console.WriteLine($"Box1: Length {b1.Length}, Breadth {b1.Breadth}, Height {b1.Height}, Volume {b1.Volume()}, Perimeter {b1.Perimeter()}");
            Console.WriteLine($"Box2: Length {b2.Length}, Breadth {b2.Breadth}, Height {b2.Height}, Volume {b2.Volume()}, Perimeter {b2.Perimeter()}");
            Console.WriteLine($"Box3: Length {b3.Length}, Breadth {b3.Breadth}, Height {b3.Height}, Volume {b3.Volume()}, Perimeter {b3.Perimeter()}");
        }
    }
}

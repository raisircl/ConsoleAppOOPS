//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace ConsoleAppOOPS
//{
//    internal class BikeProgram
//    {
//        static void Main()
//        {
//            Bike b1 = new Bike();
//            Bike b2 = new Bike();
//            Bike b3 = new Bike("Green");

//            b1.BikeColor = "Red";
//            b2.BikeColor = "Blue";
            
//            Bike b4 = new Bike(b2);

//            Console.WriteLine($"Bike{b1.SrNo} Color: {b1.BikeColor}, Price {Bike.BikePrice}");
//            Console.WriteLine($"Bike{b2.SrNo} Color: {b2.BikeColor}, Price {Bike.BikePrice}");
//            Console.WriteLine($"Bike{b3.SrNo} Color: {b3.BikeColor}, Price {Bike.BikePrice}");
//            Console.WriteLine($"Bike{b4.SrNo} Color: {b4.BikeColor}, Price {Bike.BikePrice}");

//            Bike.HikePrice(20);
//            Console.WriteLine($"Bike {b1.SrNo}  Color: {b1.BikeColor}, Price {Bike.BikePrice}");
//            Console.WriteLine($"Bike {b2.SrNo}  Color: {b2.BikeColor}, Price {Bike.BikePrice}");
//            Console.WriteLine($"Bike{b3.SrNo} Color: {b3.BikeColor}, Price {Bike.BikePrice}");
//            Console.WriteLine($"Bike{b4.SrNo} Color: {b4.BikeColor}, Price {Bike.BikePrice}");

//            Console.WriteLine($"No of Bikes Manufactured {Bike.SrCounter}");
//        }
//    }
//}

using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppOOPS
{
    internal class Bike
    {
        private string? color;
        private int srno;
        private static int srcounter = 0; // preserve itselft last value in multiple function call
        public static decimal price=1000; // shared by all instances of the Bike class
        public Bike()
        {
            srcounter++;
            srno = srcounter;
        }
        public Bike(string? color)
        {
            this.color = color;
            srcounter++;
            srno = srcounter;
        }
        public Bike(Bike bike) // call by reference
        {
            this.color = bike.color;
            srcounter++;
            srno = srcounter;
        }
        public string? BikeColor 
        { 
            get { return color; } 
            set { color = value; } 
        }
        public static decimal HikePrice(decimal percentage)
        {
            {
                price += price * percentage / 100;
                return price;
            }
        }
        public static decimal DownPrice(decimal percentage)
        {
            {
                price -= price * percentage / 100;
                return price;
            }
        }
        public int SrNo 
        { 
            get
            {
                return srno;
            } 
        }
        public static decimal BikePrice // readonly property to access the static price variable
        {
            get { return price;  }
        } 
        public static int SrCounter
        {
            get { return srcounter; }
        }
    }
}
/*
 Static Member of a class
    1. Static variable : A static variable is shared by all the objects of the class. 
                        It is not tied to any specific instance of the class. 
                        It is declared using the static keyword and can be accessed 
                        using the class name without creating an instance of the class.
    2. Static method: A static method is a method that belongs to the class rather 
                      than any specific instance of the class. 
                      It can be called using the class name without creating an instance of the class. 
                      Static methods can only access static variables and other static methods 
                      within the same class.
 */
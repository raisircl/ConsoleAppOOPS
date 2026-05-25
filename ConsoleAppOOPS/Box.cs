using System;
using System.Collections.Generic;
using System.Text;

/*
 Inheritance: 
Acquire the mebers of existing class into new class.
existing class is called base class or parent class or super class.
new class is called derived class or child class or sub class.

 */
namespace ConsoleAppOOPS
{
    internal class Box: Rect
    {
        private int height;
        public int Height
        {
            get { return height; }
            set { height = value; }
        }
        // constructor of base class never inherited by the derived class
        // but we can call the constructor of base class from the constructor of derived class
        // using base keyword.
        public Box():base() // it will call the default constructor of base class
        {
            height = 1;
        }
        public Box(int length, int breadth, int height):base(length, breadth) // it will call the parameterized constructor of base class
        {
            this.height = height;
        }
        public Box(Box b):base(b) // it will call the copy constructor of base class
        {
            height = b.height;
        }
        public int Volume()
        {
            return Length * Breadth * Height;
        }
        public override int Perimeter()
        {
            return 4 * (Length + Breadth + Height);
        }
        // in oops refrence of parent class can hold the object of child class
        // but we cannot access the members of child class using parent class reference variable.
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppOOPS
{
    public class Rect: IShape, IMsg
    {
        //data members or properties of the class
        private int length; // instance variable - it is a variable which is declared inside the class but outside the method and it is not static
        private int breadth;
        // to deal with properties C#.net give us the special construct called property unit
        // Property Unit - Three Access Provide to data memeber 
        // 1. Get Accessor - To read the value of data member
        // 2. Set Accessor - To write the value of data member
        // if a property unit has only get accessor then it is called read only property unit
        // and if a property unit has only set accessor then it is called write only property unit
        public Rect() // default constructor
        {
            length = 1;
            breadth = 1;
        }
        public Rect(int length, int bre) // parameterized constructor
        {
            this.length = length;
            breadth = bre;
        }
        public Rect(Rect r) // copy constructor
        {
            length = r.length;
            breadth = r.breadth;
        }
        public  int Length
        {
            get { return length;  }
            set { length = value; }
        }
        public int Breadth
        {
            get { return breadth; }
            set { breadth = value; }
        }
        public int Area()
        {
                return length * breadth;
        }
        public virtual int Perimeter()
        {
            return 2 * (length + breadth);
        }
        public override string ToString()
        {
            return $"{length}x{breadth}";
        }

        public virtual void ShowMsg(string msg)
        {
            Console.WriteLine($"Message from Rect class: {msg}");
        }
    }
}

/// <summary>
/// Oops - Object Oriented Programming System
/// Programming - An Aprroach to Problem Solving or Write a Program
/// If Programming is oriented towards Object then it is called Object Oriented Programming System
/// Object - Anything which exist in the world which has description
/// Object - A Person , A Place , A Thing
/// OOPS - A Programming Paradigm which is based on the concept of Object
/// Class - A Blueprint or Template or Design of an Object - It has description.
/// Object - Physicaly exist in the world in memory of the computer
/// Relation between Class and Object - 
///         Class gives theoratical description of an Object
///         Object is real life representation of a Class
/// Encapsulation - It is a process to wrap the information about an object in asingle unit
///     After encapsulation the encapsulated unit is known as class and class has followingn key components
///     1. Properties - Decide how an object will look like
///     2. Methods/Function - Decide how an object will behave
///     3. Event - What type of action taken by an object
///     4. Event Handler - When we associate an event with a function then that function is called event handler
///     Note - During encapsulation we will also decide which one member of the class will be private or public 
///     So to make a member private is known as data hiding and to make a member public is known as data abstraction
///Absraction - it is a process to represent the complexcity in very simple manner 
///         In absraction we will hide the complex details and show only the necessary details to the user
///Polymorphism - It is a process to take many forms of a function, operator or constructor
///Inheritance - It is a process to acquire the properties and behaviour of one class to another class
///</summary>
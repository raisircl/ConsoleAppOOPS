using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppOOPS
{
    internal interface IShape
    {
        int Area();
        int Perimeter();
    }
}
/*
In C++ we create Pure Abstract Class : This has functions of without body which 
are defined as pure virtual function and constants. 
In C#.Net Pure Abstract class known as interface.
Interface contains mustoveridable functions and constants.
Interface sign a contract with class that is "Interface provide only declaration of function but not definition of function. So class which implement the interface must provide the definition of function."
class needs to implement all the functions of interface otherwise class will be abstract class.
As we know we can not create an object of abstract class.

Interface developer provides only declaration of function but not definition of function. 
So class which implement the interface must provide the definition of function.

 */
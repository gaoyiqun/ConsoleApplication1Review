using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson8
{
   
    public class Program
    {

        static void Main(string[] args)
        {
            Child child = new Child();

            child.print();

            ((Parent)child).print();
            //Another way to access base class members is through an explicit cast. 
            //This is done in the last statement of the Child class Main() method.
            //Remember that a derived class is a specialization of its base class. 
            //This fact allows us to perform a cast on the derived class, making it an instance of its base class.
            Console.ReadLine();
        }
    }
}

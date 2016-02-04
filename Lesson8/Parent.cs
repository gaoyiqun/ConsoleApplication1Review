using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson8
{
    public class Parent
    {
        string parentString;
        
        public Parent()
        {
            Console.WriteLine("Parent Constructor.");
        }

        public Parent(string myString)
        {
            parentString = myString;
            Console.WriteLine(parentString);
        }

        public void print()
        {
            Console.WriteLine("I'm a Parent Class.");
        }
    }
}

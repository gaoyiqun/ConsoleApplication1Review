using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson8
{
    public class Child:Parent
    {
        /// <summary>
        /// Derived classes can communicate with base classes during instantiation.
        /// 
        /// </summary>
        public Child(): base ("From Derived")
        {
            Console.WriteLine("Child Constructor.");

        }

        /// <summary>
        /// Notice the new modifier on the Child class print() method. 
        /// This enables this method to hide the Parent class print() method 
        /// and explicitly states your intention that you don't want polymorphism to occur. 
        /// Without the new modifier, the compiler will produce a warning to draw your attention to this.
       ///  See the next lesson for a detailed discussion of polymorphism.
        /// </summary>
        public new void print()
        {
            base.print();

            Console.WriteLine("I'm a Child Class");
        }

        
    }
}

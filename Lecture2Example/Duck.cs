using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lecture2Example
{
    public class Duck: Animal
    {
        public override void Walk()
        {
            base.Walk();
            Console.WriteLine("Duck is walking");
        }
             
    }
}

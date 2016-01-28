using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1Review
{
    public class Donkey : Animal
    {
        public override void Walk()
        {
            //base.Walk();
            Console.WriteLine("Donkey is walking");
        }
    }
}

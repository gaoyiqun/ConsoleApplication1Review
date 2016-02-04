using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1Review
{
    public class Duck : Animal
    {
        public override void Walk()
        {
            //base.Walk();
            Console.WriteLine("Duck is walking");
        }
    }
}

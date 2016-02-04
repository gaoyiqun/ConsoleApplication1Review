using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson9
{
    public class DrawingObject
    {
        public virtual void Draw()
        {
            Console.WriteLine("I'm just a generic drawing object.");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson9
{
    public class Line : DrawingObject
    {
        public override void Draw()
        {
            Console.WriteLine("I'm a line.");
        }

    }

    public class Cricle : DrawingObject
    {
        public override void Draw()
        {
            Console.WriteLine("I'm a cricle");
        }
    }

    public class Square : DrawingObject
    {
        public override void Draw()
        {
            Console.WriteLine("I'm a Square");
        }
    }


    public class DrawDemo
    {
        public static int Main()
        {
            DrawingObject[] dObj = new DrawingObject[4];

            dObj[0] = new Line();
            dObj[1] = new Cricle();
            dObj[2] = new Square();
            dObj[3] = new DrawingObject();

            foreach (DrawingObject drawObj in dObj)
            {
                drawObj.Draw();
            }

            return 0;

        }
    }
}

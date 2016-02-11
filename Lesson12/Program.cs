using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson12
{
    class Program
    {
        /// <summary>
        /// While a struct is a value type, a class is a reference type. 
        /// Value types hold their value in memory where they are declared, 
        /// but reference types hold a reference to an object in memory. 
        /// 
        /// If you copy a struct, 
        /// C# creates a new copy of the object and 
        /// assigns the copy of the object to a separate struct instance. 
        /// However, 
        /// if you copy a class, 
        /// C# creates a new copy of the reference to the object and 
        /// assigns the copy of the reference to the separate class instance. 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //rectangle rect1 = new rectangle();


            //rect1.width = 1;
            //rect1.height = 3;

            //Rectangle rect1 = new Rectangle
            //{
            //    Width = 1,
            //    Height = 3
            //};
            OverLoadRectangle rect1 = new OverLoadRectangle();
            rect1.Width = 1;
            rect1.Height = 3;
            Console.WriteLine("rect1: {0}:{1}", rect1.Width, rect1.Height);



            OverLoadRectangle rect2 = new OverLoadRectangle(5, 7);

            Console.WriteLine("rect2: {0}:{1}", rect2.Width, rect2.Height);

            OverLoadRectangle rect3 = rect1.Add(rect2);
            Console.WriteLine("rect3: {0}:{1}", rect3.Width, rect3.Height);


            Console.ReadKey();
        }



    }
}

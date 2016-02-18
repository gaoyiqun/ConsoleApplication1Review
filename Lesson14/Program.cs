using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson14
{
  

    class Program
    {
        static void Main(string[] args)
        {
            
            SimpleDelegate sd = new SimpleDelegate();

            //this is the delegate instantiation
            Comparer cmp = new Comparer(SimpleDelegate.CompareFirstNames);

            Console.WriteLine("\nBefore Sort:\n");

            sd.PrintNames();

            Console.WriteLine("\nAfter Sort:\n");

            sd.Sort(cmp);

            sd.PrintNames();

            Console.ReadLine();
            



         //   Application.Run(new Eventdemo());
        }

    }
}

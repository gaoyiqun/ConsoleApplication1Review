using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson14Practise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Delegate dele = new Delegate();

            Comparer cmpf = new Comparer(Delegate.CompareFirstNames);

            Comparer cmpl = new Comparer(Delegate.CompareLastNames);

            Console.WriteLine("\n Before Sort: \n");

            dele.PrintNames();

            dele.Sort(cmpf);

            Console.WriteLine("\n After CompareFirstNames Sort: \n");

            dele.PrintNames();

            dele.Sort(cmpl);

            Console.WriteLine("\n After CompareLastNames Sort: \n");

            dele.PrintNames();

            Console.ReadLine();
                 
        }
    }
}

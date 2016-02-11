using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson11
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 10;
            OvrIndexer myInd = new OvrIndexer(size);

            myInd[9]= "Some Value";
            myInd[3] = "Another Value";
            myInd[5] = "Any Value";

            myInd["empty"] = "no value";

            Console.WriteLine("\nIndexer Output\n");

            for (int i =0; i< size;i++)
            {
                Console.WriteLine("myInd[{0}]:{1}", i, myInd[i]);
            }

            Console.WriteLine("Number of no value entries: {0}", myInd["no value"]);

            Console.ReadLine();
        }
    }
}

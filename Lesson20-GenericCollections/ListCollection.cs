using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson20_GenericCollections
{
    /// <summary>
    /// one huge benefit is that generics allow us to 
    /// create collections that allow us to do more than allowed by an array.
    /// 
    /// The problem with ArrayList and all the other .NET v1.0 collections 
    /// is that they operate on type object.
    /// 
    /// A generic collection is strongly typed (type safe), 
    /// meaning that you can only put one type of object into it. 
    /// This eliminates type mismatches at runtime.
    /// 
    /// Another benefit of type safety is that performance is better with value type objects 
    /// because they don't incur overhead of being converted to and from type object.
    /// </summary>
    class ListCollection
    {
        static void Main(string[] args)
        {
            
            List<int> myInts = new List<int>();

            myInts.Add(1);
            myInts.Add(2);
            myInts.Add(3);

            for (int i=0; i<myInts.Count; i++)
            {
                Console.WriteLine("MyInts: {0}", myInts[i]);
            }
            

            
            /// the meaning of customers is that it is a Dictionary where the key is type int and the value is type Customer. 
            /// Therefore, any time you add an entry to the Dictionary, you must provide the key because it is also the key that you will use to extract a specified Customer from the Dictionary.
            Dictionary<int, Customer> customers = new Dictionary<int, Customer>();

            Customer cust1 = new Customer(1, "Cust 1");
            Customer cust2 = new Customer(2, "Cust 2");
            Customer cust3 = new Customer(3, "Cust 3");

            customers.Add(cust1.ID, cust1);
            customers.Add(cust2.ID, cust2);
            customers.Add(cust3.ID, cust3);

            foreach (KeyValuePair<int, Customer> custKeyVal in customers)
            {
                Console.WriteLine("Customer ID: {0}, Name: {1}", custKeyVal.Key, custKeyVal.Value.Name);

            }

            Console.ReadLine();
        }
    }
}
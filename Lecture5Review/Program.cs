using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Lecture5Review
{
    class Program
    {
        static void Main(string[] args)
        {
            void DI();
        }

        static void OldWay()
        {
            // this is what is normally done, but not very good

            ClassA instanceA = new ClassA();
            // DynamicTYping
            ClassC instanceC = new ClassC(instanceA);

            int sum = instanceC.GetSum(2, 3);
        }

        static void DI()
        {
            //Create container
            UnityContainer container = new UnityContainer();
            container.
        }

    }
}

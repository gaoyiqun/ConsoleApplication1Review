using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {

            DI();





     
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

            container.RegisterType<IMyInterface, ClassB>();

            // Following code does not have depdency on ClassA or ClassB
            IMyInterface implement = container.Resolve<IMyInterface>();

            ClassC instanceC = new ClassC(implement);

            int sum = instanceC.GetSum(2, 3);

        }
    }
}

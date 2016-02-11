using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson13
{
    class Program
    {
        static void Main()
        {
            InterfaceImplementer iImp = new InterfaceImplementer();
            iImp.MethodToImplement();
            iImp.ParentInterfaceMethod();

            Console.ReadLine();
        }
    }
}

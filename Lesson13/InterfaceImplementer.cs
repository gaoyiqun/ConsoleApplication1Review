using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson13
{
    class InterfaceImplementer: IMyInterface
    {
        public void MethodToImplement()
        {
            Console.WriteLine("MethodToImplement() called.");
        }

        public void ParentInterfaceMethod()
        {
            Console.WriteLine("ParentInterfaceMethod() called");
        }
    }
}

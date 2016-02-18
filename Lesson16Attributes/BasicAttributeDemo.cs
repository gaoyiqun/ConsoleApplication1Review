using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson16Attributes
{
    class BasicAttributeDemo
    {
        [Obsolete]
        public void MyFirstDeprecatedMethod()
        {
            Console.WriteLine("Called MyFirstDeprecatedMethod().");
        }

        [ObsoleteAttribute]
        public void MySecondDeprecatedMethod()
        {
            Console.WriteLine("Called MySecondDeprecatedMethod().");

        }

        [Obsolete("You shouldn't use this method anymore.")]
        public void MyThirdDeprecatedMethod()
        {
            Console.WriteLine("Called MyThirdDeprecatedMethod().");
        }

       

    }
}

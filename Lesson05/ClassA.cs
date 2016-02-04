using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson05
{
    public class ClassA : IMyInterface, IMyInterface2
    {
        public string Name { get; set; }

        public void Mothod1()
        {
            Name = "MY interface blah";
         
        }

        public int Mothd2(int a, int b)
        {
            return a + b;
        }
    }
}

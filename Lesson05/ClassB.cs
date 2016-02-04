using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson05
{
    public class ClassB : IMyInterface
    {
        public int Age { get; set; }


        public void Mothod1()
        {
            Age++;
        }

        public int Mothd2(int a, int b)
        {
            return a + b + Age;

        }
    }
}

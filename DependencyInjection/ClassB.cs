using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class ClassB : IMyInterface
    {
        public int AddTwoNumbers(int a, int b)
        {
            return a + b - 1;
        }
    }
}

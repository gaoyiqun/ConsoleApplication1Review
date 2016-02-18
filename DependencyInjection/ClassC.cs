using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class ClassC
    {
        private IMyInterface _implement;
        public ClassC(IMyInterface implement)
        {
            _implement = implement;
        }

        public int GetSum(int a, int b)
        {
            return 2*_implement.AddTwoNumbers(a, b);
        }
    }
}

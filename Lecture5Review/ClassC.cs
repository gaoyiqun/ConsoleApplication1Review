using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lecture5Review
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
            return _implement.AddTwoNumbers(a, b);
        }
        
    }
}

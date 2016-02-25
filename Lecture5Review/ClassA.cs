using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lecture5Review
{
    public class ClassA : IMyInterface
    {
        public int AddTwoNumbers(int a, int b)
        {
            return a + b;
        }

        public string TrimString(string input)
        {
            if(input == null)
            {
                return null;
            }
            else { return input.Trim(); }
        }

        public string TrimStringNotNull(string input)
        {
            if (input == null)
            {
                throw new NullReferenceException();
            }
            else { return input.Trim(); }
        }

    }
}

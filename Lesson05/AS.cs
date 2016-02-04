using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson05
{
    public abstract class AS
    {
        public int Age { get; set; }

        public void MYMethod(string s)
        {
            s = s.Trim();

        }
        public abstract void Method2();

    }
}

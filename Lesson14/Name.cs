using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson14
{

    public class Name
    {
        public string FirstName = null;
        public string LastName = null;

        public Name(string first, string last)
        {
            FirstName = first;
            LastName = last;
        }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }

 
}

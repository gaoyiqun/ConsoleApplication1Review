using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson05
{
    public class Address
    {
        public string name;
        public string detailaddr;

        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }

        public string Detailaddr
        {
            set
            {
                detailaddr = value;

            }
            get
            {
                return detailaddr;
            }
        }

        public static explicit operator Address(string v)
        {
            throw new NotImplementedException();
        }
    }
}

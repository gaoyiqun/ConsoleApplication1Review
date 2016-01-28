using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1Review
{
    public class Student
    {
        // when you do not have a constructor, all the members are initiated too, but to their default values
        // every type has different default values
        // int =0;
        //string is null
        // class type is null;
        // bool  default value is False

        private int age;
        private string firstName;

        public string Name;

        //proprities: all properties must be public. all properties must have get and set method
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
              
                if (value < 0)
                {
                    throw new Exception("Age Should not be less than 0"); //When execute does not throw exceptions...
                }
                age = value;
            }
        }
    }
}

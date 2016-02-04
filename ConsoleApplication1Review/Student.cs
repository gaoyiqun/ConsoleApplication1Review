using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1Review
{
    public class Student
    {
        private int age;
       // private string firstName;

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
                if (age < 0)
                {
                    throw new Exception(); //When execute does not throw exceptions...
                }
                age = value;
            }
        }

        public string LastName { get; set; }

        public Student()
        {
            age = 8;

        }

        public Student(int _age)
        {
            age = _age;
        }


    }
}

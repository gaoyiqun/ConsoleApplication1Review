using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1Review
{
    
    public class Methods
    {
        //write a method in Method Class
        //This method return a MyClass.cs class
        public MyClass MyMethod()
        {
            return new MyClass();
        }

        //The method some times is like a contract, What you pass in and what ir returns
        public List<Student> GetStudents()
        {
            List<Student> list1 = new List<Student>();
            Student student1 = new Student();
            list1.Add(student1);
            Student student2 = new Student();
            list1.Add(student2);

            return list1;

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1Review
{
    class Program
    {
        static void Main(string[] args)
        {
          /*  MyClass myclass = new MyClass();
            myclass.ClassTypeInt = 8;
            int intTypeInt = 4;
            int result = CompareTypesResultValues(intTypeInt, myclass);

            Console.WriteLine("After actions, ClassType result value is changed: {0}", myclass.ClassTypeInt);
            Console.WriteLine("After actions, ValueType result value is unchanged: {0}",intTypeInt);
            Console.WriteLine(result);

            Console.ReadLine();
            */
            TestStudent();
            Console.ReadLine();
        }

        //This is a function, we will pass in different type of parameters
        static int CompareTypesResultValues(int v, MyClass c)
        {
            //If I change c.ClassTypeInt, the changes will be seen on c
            v = 10;

            c.ClassTypeInt = v;

          

            return c.ClassTypeInt;
        }

        static void TestStudent()
        {
            Student studentTest = new Student();

            Student studentTest2 = new Student(19);

            studentTest.Age = -10;
            Console.WriteLine(studentTest.Age);

            studentTest.LastName = "Gao";
            Console.WriteLine(studentTest.LastName);

            Console.ReadLine();
        }
    }
}

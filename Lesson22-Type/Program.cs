using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson22_Type
{
    class Program
    {
        static void Main(string[] args)
        {
            /** 
            <<explicit&implicit conversion>>
            
            float lengthFloat = 7.35f;

            //lose precision - explicit conversion
            int lengthInt = (int)lengthFloat;

            //no problem - implicit conversion
            double lengthDouble = lengthInt;

            Console.WriteLine("lengthInt = " + lengthInt);
            Console.WriteLine("lengthDouble = " + lengthDouble);
            Console.ReadKey();
            **/

            /**
            Employee joe = new Employee();
            joe.Name = "Joe";

            Employee bob = new Employee();
            bob.Name = "Bob";

            Console.WriteLine("Original Employee Values: ");
            Console.WriteLine("joe = " + joe.Name);
            Console.WriteLine("bob = " + bob.Name);

            //assign joe reference to bob variable
            bob = joe;

            Console.WriteLine();
            Console.WriteLine("Values After Reference Assignment:");
            Console.WriteLine("joe = " + joe.Name);
            Console.WriteLine("bob = " + bob.Name);

            bob.Name = "Bobbi Jo";

            Console.WriteLine();
            Console.WriteLine("Values After Changing One Instance:");
            Console.WriteLine("joe = " + joe.Name);
            Console.WriteLine("bob = " + bob.Name);

            Console.ReadKey();

            ///The following types are reference types: arrays; class; delegates; interfaces

            **/
            Height joe = new Height();
            joe.Inches = 71;

            Height bob = new Height();
            bob.Inches = 59;

            Console.WriteLine("Original Height Values:");
            Console.WriteLine("joe = " + joe.Inches);
            Console.WriteLine("bob = " + bob.Inches);

            // assign joe value to bob variable
            bob = joe;

            Console.WriteLine();
            Console.WriteLine("Values After Value Assignment:");
            Console.WriteLine("joe = " + joe.Inches);
            Console.WriteLine("bob = " + bob.Inches);

            joe.Inches = 65;

            Console.WriteLine();
            Console.WriteLine("Values After Changing One Instance:");
            Console.WriteLine("joe = " + joe.Inches);
            Console.WriteLine("bob = " + bob.Inches);

            Console.ReadKey();
        }

    }
    
}

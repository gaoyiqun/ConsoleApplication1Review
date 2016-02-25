
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace LateBindingReflection
{
    public class Program
    {
        public static void Main()
        {
            Assembly executingAssembly = Assembly.GetExecutingAssembly();

            Type customerType = executingAssembly.GetType("LateBindingReflection.Customer");

            object customerInstance = Activator.CreateInstance(customerType);

            MethodInfo getFullNameMethod = customerType.GetMethod("GetFullName");

            string[] parameters = new string[2];
            parameters[0] = "Irene";
            parameters[1] = "Gao";

            string fullName = (string)getFullNameMethod.Invoke(customerInstance, parameters);

            Console.WriteLine("Full Name = {0}", fullName);
            Console.ReadLine();
        }
    }

    public class Customer
    {
        public string GetFullName(string FirstName, string LastName)
        {
            return FirstName + " " + LastName;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// Properties provide the opportunity to protect a field in a class by reading and writing to it through the property. 
/// In other languages, this is often accomplished by programs implementing specialized getter and setter methods. 
/// C# properties enable this type of protection while also letting you access the property just like it was a field.
/// 
/// Another benefit of properties over fields is that you can change their internal implementation over time. 
/// With a public field, the underlying data type must always be the same because calling code depends on the field being the same. 
/// However, with a property, you  can change the implementation. 
/// For example, if a customer has an ID that is originally stored as an int, 
/// you might have a requirements change that made you perform a validation to ensure that calling code could never set the ID to a negative value. 
/// If it was a field, you would never be able to do this, but a property allows you to make such a change without breaking code. 
/// Now, lets see how to use properties.
/// </summary>
namespace Lesson10
{

    public class CustomerManagerWithAccessorMethods
    {
        public static void Main(string[] args)
        {
            Customer cust = new Customer();

            cust.SetID(1);
            cust.SetName("Amelo Rosles");

            Console.WriteLine("ID:{0}, Name:{1}", cust.GetID(), cust.GetName());

            Console.ReadKey();
        }
    }
}

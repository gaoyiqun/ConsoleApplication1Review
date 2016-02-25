using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson17_Enums
{
    /// <summary>
    /// Enums are strongly typed constants. 
    /// They are essentially unique types that allow you to assign symbolic names to integral values.
    /// In C# tradition, they are strongly typed, 
    /// meaning that an enum of one type may not be implicitly assigned to an enum of another type 
    /// even though the underlying value of their members are the same.
    /// 
    /// Along the same lines, integral types and enums are not implicitly interchangable.
    /// All assignments between different enum types and integral types require an explicit cast.
    /// 
    /// </summary>
    class Enumtricks
    {
        /// <summary>
        /// By default, the underlying type of an enum is int. 
        /// This default may be changed by specifying a specific base when declaring the enum.
        /// </summary>
        
        public enum Volume: byte
        {
            Low =1,
            Medium,
            High
        }

        /**
        static void Main(string[] args)
        {
            //Console.WriteLine("Choose Volume: Low=0, Medium=1, High=2");

            //  string input = Console.ReadLine();

            //  Volume myVolume = (Volume)Convert.ToInt32(input);

            Volume myVolume = Volume.Low;

            switch (myVolume)
            {
                case Volume.Low:
                    Console.WriteLine("The volume has been turned Down");
                    break;
                case Volume.Medium:
                    Console.WriteLine("The volume is in the middle");
                    break;
                case Volume.High:
                    Console.WriteLine("The volume has been tunred Up");
                    break;
            }
            Console.ReadLine();
        }
        **/

        static void Main(string[] args)
        {
            //instantiate type
            Enumtricks enumtricks = new Enumtricks();

            //demonstrates explicit cast of int to Volume
            enumtricks.GetEnumFromUser();

            //iterate through Volume enum by name
            enumtricks.ListEnumMembersByName();

            //iterate through Volume enum by value
            enumtricks.ListEnumMembersByValue();

            Console.ReadLine();
        }

        private void GetEnumFromUser()
        {
            Console.WriteLine("\n----------------");
            Console.WriteLine("Volume Settings:");
            Console.WriteLine("----------------\n");

            Console.Write(@"
                            1 - Low
                            2 - Medium
                            3 - High

                            Please select one (1, 2, or 3): ");

            //get value user provided
            string volString = Console.ReadLine();
            int volInt = Int32.Parse(volString);

            //perform explicit cast from int to Volume enum type
            Volume myVolume = (Volume)volInt;

            Console.WriteLine();

            switch (myVolume)
            {
                case Volume.Low:
                    Console.WriteLine("The volume has been turned Down.");
                    break;
                case Volume.Medium:
                    Console.WriteLine("The volume is in the middle.");
                    break;
                case Volume.High:
                    Console.WriteLine("The volume has been turned up.");
                    break;
            }
        }

        public void ListEnumMembersByName()
        {
            Console.WriteLine("\n---------------------------- ");
            Console.WriteLine("Volume Enum Members by Name:");
            Console.WriteLine("----------------------------\n");

            foreach (string volume in Enum.GetNames(typeof(Volume)))
            {
                Console.WriteLine("Volume Member: {0}\n Value:{1}", 
                    volume, (byte)Enum.Parse(typeof(Volume), volume));
            }
        }

        public void ListEnumMembersByValue()
        {
            Console.WriteLine("\n----------------------------- ");
            Console.WriteLine("Volume Enum Members by Value:");
            Console.WriteLine("-----------------------------\n");

            // get all values (numeric values) from the Volume
            // enum type, figure out member name, and display
            foreach (byte val in Enum.GetValues(typeof(Volume)))
            {
                Console.WriteLine("Volume Value: {0}\n Member: {1}",
                    val, Enum.GetName(typeof(Volume), val));
            }
        }
    }
}

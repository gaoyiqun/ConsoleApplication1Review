using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson14
{
    public delegate int Comparer(object obj1, object obj2);

    public class SimpleDelegate
    {
        Name[] names = new Name[5];

        public SimpleDelegate()
        {
            names[0] = new Name("Joe","Mayo");
            names[1] = new Name("John","Hancock");
            names[2] = new Name("Jane","Doe");
            names[3] = new Name("John","Doe");
            names[4] = new Name("Jack","Smith");
        }

        public static int CompareFirstNames(object name1, object name2)
        {
            string n1 = ((Name)name1).FirstName;
            string n2 = ((Name)name2).FirstName;

            if (String.Compare(n1, n2) > 0)
            {
                return 1;
            }
            else if (String.Compare(n1, n2) < 0)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        internal void PrintNames()
        {
            Console.WriteLine("Names:\n");

            foreach (Name name in names)
            {
                Console.WriteLine(name.ToString());
            }
        }

        internal void Sort(Comparer compare)
        {
            object temp;

            for (int i = 0; i< names.Length; i++)
            {
                for(int j= i; j<names.Length; j++)
                {
                    if (compare(names[i], names[j])>0)
                    {
                        temp = names[i];
                        names[i] = names[j];
                        names[j] = (Name)temp;
                    }
                }
            }
        }
    }
}

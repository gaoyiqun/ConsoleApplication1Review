using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson11
{
    class IntIndexer
    {
        private string[] myData;
        /// <summary>
        /// The IntIndexer class has a string array named myData. 
        /// This is a private array that external users can't see.
        /// </summary>
        /// <param name="size"></param>

        public IntIndexer(int size)
        {
            myData = new string[size];

            for (int i= 0; i<size; i++)
            {
                myData[i] = "empty";
            }
        }

        public string this[int pos]
        {
            get
            {
                return myData[pos];
            }
            set
            {
                myData[pos] = value;
            }
        }
       
    }
}

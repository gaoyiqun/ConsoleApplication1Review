using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson11
{
    class OvrIndexer
    {
        private string[] myData;
        private int arrSize;

        public OvrIndexer(int size)
        {
            arrSize = size;

            myData = new string[size];

            for (int i = 0; i < size; i++)
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

        public string this[string data]
        {
           /// but there is a new Indexer that takes a string parameter.
           /// The get accessor of the new indexer returns a string representation of the number of items 
           /// that match the parameter value, data. 
           /// The set accessor changes each entry in the array that 
           /// matches the data parameter to the value 
           /// that is assigned to the Indexer.
            get
            {
                int count = 0;

                for(int i = 0; i < arrSize; i++)
                {
                    if(myData[i] == data)
                    {
                        count++;
                    }
                }
                return count.ToString();
            }
            set
            {
                for(int i=0; i<arrSize; i++)
                {
                    if (myData[i] == data)
                    {
                        myData[i] = value;
                    }
                }
            }
        }

    }
}

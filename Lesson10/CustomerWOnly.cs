using System;

namespace Lesson10
{
    public  class CustomerWOnly

    {
        private int m_id = -1;    //*******

        private string m_name = string.Empty;

        public int ID
        {
            set
            {
                m_id = value;
            }
           
        }

        public string Name
        {
            set
            {
                m_name = value;
            }
   
        }

        public void DisplayCustomerData()
        {
            Console.WriteLine("ID:{0}, Name:{1}", m_id, m_name);
        }

      
    }
}
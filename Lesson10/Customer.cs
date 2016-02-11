namespace Lesson10
{
    public  class Customer
    {
        private int m_id = -1;    //*******

        private string m_name = string.Empty;

        public Customer(int id, string name)
        {
            m_id = id;
            m_name = name;
        }

        public int ID
        {
            get
            {
                return m_id;
            }
           
        }

        

        public string Name
        {
            get
            {
                return m_name;
            }
   
        }

      
    }
}
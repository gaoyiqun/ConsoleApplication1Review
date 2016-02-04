namespace Lesson10
{
    public  class Customer
    {
        private int m_id = -1;    //*******

        public int ID
        {
            get
            {
                return m_id;
            }
            set
            {
                m_id = value;
            }
        }

        private string m_name = string.Empty;

        public string Name
        {
            get
            {
                return m_name;
            }
            set
            {
                m_name = value;
            }
        }

      
    }
}
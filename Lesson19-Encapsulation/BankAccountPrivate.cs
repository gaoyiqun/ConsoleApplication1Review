using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson19_Encapsulation
{
    class BankAccountPrivate
    {
        private string m_name;

        /// <summary>
        /// m_name is declared as private, 
        /// code outside the BankAccountPrivate class can't access it directly. 
        /// They must use the public CustomerName property instead.
        /// 
        /// The private and public access modifiers are at the two extremes of access, 
        /// either denying all external access or allowing all external access, respectively. 
        /// </summary>

        public string CustomerName
        {
            get { return m_name; }
            set { m_name = value; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson19_Encapsulation
{
    class BankAccountProtected
    {
      public void CloseAccount()
        {
            ApplyPenalties();
            CalculateFinalInterest();
            DeleteAccountFromDB();
        }
        /// <summary>
        /// Any calling code can instantiate BankAccountProtected, 
        /// but it can only call the CloseAccount method. 
        /// This gives you protection from someone invoking the behavior of your object in inappropriate ways. 
        /// Your business logic is sound.
        /// </summary>
        protected virtual void ApplyPenalties()
        {
            //deduct form account
        }

        protected virtual void CalculateFinalInterest()
        {
            //add to account
        }

        protected virtual void DeleteAccountFromDB()
        {
            //send notification to data entry personnel
        }
    }
}

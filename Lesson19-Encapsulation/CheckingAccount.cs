using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson19_Encapsulation
{
    class CheckingAccount:BankAccountProtected
    {
        protected override void ApplyPenalties()
        {
            Console.WriteLine("Checking Account Applying Penalties");
        }

        protected override void CalculateFinalInterest()
        {
            Console.WriteLine("CheckingAccount Calculating Final Interest");
        }

        protected override void DeleteAccountFromDB()
        {
            base.DeleteAccountFromDB();
            Console.WriteLine("Checking Account Deleting Account From DB");
        }

    }
}

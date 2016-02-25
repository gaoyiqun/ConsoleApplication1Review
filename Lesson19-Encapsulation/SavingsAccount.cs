using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson19_Encapsulation
{
    class SavingsAccount:BankAccountProtected
    {
        protected override void ApplyPenalties()
        {
            Console.WriteLine("Savings Account Applying Penalties");
        }

        protected override void CalculateFinalInterest()
        {
            Console.WriteLine("Savings Account Calculating Final Interest");
        }

        protected override void DeleteAccountFromDB()
        {
            base.DeleteAccountFromDB();
            Console.WriteLine("Savings Account Deleting Account From DB");
        }

    }
}

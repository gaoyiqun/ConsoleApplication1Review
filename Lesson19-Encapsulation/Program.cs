using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson19_Encapsulation
{
    /// <summary>
    /// While you can use any of the access modifiers on type members, 
    /// the only two access modifiers you can use on types are the public and internal.
    /// </summary>
    class Program
        
    {
        static void Main(string[] args)
        {
            BankAccountPublic bankAcctPub = new BankAccountPublic();

            //call a public method
            decimal amount = bankAcctPub.GetAmount();

            BankAccountProtected[] bankAccts = new BankAccountProtected[2];
            bankAccts[0] = new SavingsAccount();
            bankAccts[1] = new CheckingAccount();

            foreach (BankAccountProtected acct in bankAccts)
            {
                // call public method, which invokes protected virtual methods
                acct.CloseAccount();
            }

            Console.ReadLine();
        }
    }
}

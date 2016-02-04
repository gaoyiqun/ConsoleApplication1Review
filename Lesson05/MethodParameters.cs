using System;
using System.Collections;
using System.Collections.Generic;

using System.Text;
using System.Linq;

namespace Lesson05{

    class MethodParameters
    {

        public Address addr { get; set; }


        public static void Main()
        {

            string userChoice;

         
            ArrayList addrArray = new ArrayList(); //Use to save addresses

            MethodParameters mp = new MethodParameters();

            do
            {
                //show menu and get input from user
                userChoice = mp.getChoice();

                //make a decision based on user's choice
                mp.makeDecision(userChoice, addrArray);

                Console.Write("press Enter key to continue...");
                Console.ReadLine();
                Console.WriteLine();
            }
            while (userChoice != "Q" && userChoice != "q");
        }

        string getChoice()
        {
            string haveChoice;

            Console.WriteLine("My Address Book\n");

            Console.WriteLine("A - Add New Address");
            Console.WriteLine("D - Delete Address");
            Console.WriteLine("M - Modify Address");
            Console.WriteLine("V - View Addresses");
            Console.WriteLine("Q - Quit\n");

            Console.WriteLine("Choice (A,D,M,V,or Q): ");

            haveChoice = Console.ReadLine();

            return haveChoice;
        }



        void makeDecision(string myChoice, ArrayList addrArray)
        {
            
           
            /** The switch statement in makeDecision() calls a method for each case. 
              * These method calls are different from the ones we used in Main().
              * Instead of using the mp reference, they use the this keyword. 
              * this is a reference to the current object. 
              * We know the current object has been instantiated because makeDecision() is not a static method. 
              * Therefore, we can use the this reference to call methods within the same instance.
              ***/
            switch (myChoice)
            {
                case "A":
                case "a":
                    Address addr = new Address();
                    this.addAddress(ref addr);   //ref?
                    addrArray.Add(addr);
                    break;
                case "D":
                case "d":
                    
                    this.deleteAddress(addrArray);
                    break;
                case "M":
                case "m":
                  //  addr.name = "Matt";
                   // this.modifyAddress(out addr);   //out?
                   // Console.WriteLine("Name is modified, now {0}.", addr.name);
                    break;
                case "V":
                case "v":
                    this.viewAddress(addrArray);
                    break;
                case "Q":
                case "q":
                    Console.WriteLine("Bye.");
                    break;
                default:
                    Console.WriteLine("{0} is not a valid choice", myChoice);
                    break;
            }

        }

        void deleteAddress(ArrayList addrArray)
        {
            Console.WriteLine("Which address you want to delete?");

            string del = Console.ReadLine();

            
            foreach (object addr in addrArray)
            {
                while (del equals ((Address)addr).name = true)

                    do { addrArray.Remove(addr)};
            }

            
        }

        void modifyAddress(out Address addr)
        {
            addr = new Address();
            Console.WriteLine("Whose address you wanna to modify? ");
            addr.name = Console.ReadLine();
            Console.WriteLine("Please input the new address for {0}", addr.name);
            addr.detailaddr = Console.ReadLine();

        }

        void addAddress(ref Address addr)
        {
            Console.WriteLine("Please Enter name you wish to add:");
            addr.name = Console.ReadLine();
            Console.WriteLine("Please Enter the address for {0}:", addr.name);
            addr.detailaddr = Console.ReadLine();
            Console.WriteLine("Name: {0}, Address: {1} has been added.", addr.name, addr.detailaddr);
        }


        public void viewAddress(ArrayList addrArray)
        {
            foreach (object addr in addrArray)
            {
                Console.WriteLine("Name: {0}, Address: {1}", ((Address)addr).Name, ((Address)addr).Detailaddr);
            }
            //throw new NotImplementedException();
        }

    }
}
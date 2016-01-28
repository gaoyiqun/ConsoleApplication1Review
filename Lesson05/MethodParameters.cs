using System;
using System.Collections;
using System.Collections.Generic;

using System.Text;
using System.Linq;

namespace Lesson05{

    class MethodParameters
    {

        public ArrayList AddressList { get; set; }

        public MethodParameters()
        {
            AddressList = new ArrayList();
        }

        public static void Main()
        {

            string userChoice;

          //  ArrayList addrArray = new ArrayList(); //Use to save addresses

            MethodParameters mp = new MethodParameters();

            ArrayList addrArray = new ArrayList(); //Use to save addresses
           
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
            Address addr = new Address();

          
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
                    this.addAddress(ref addr);   //ref is the pointer
                    this.addAddressV2(addr); // this is the same as ref version, only pointer passed in
                    AddressList.Add(addr);
                    addrArray.Add(addr);
                    break;
                case "D":
                case "d":
                    addr.name = "Bojiao";
                    this.deleteAddress(addr.name);
                    break;
                case "M":
                case "m":
                    addr.name = "Matt";
                    this.modifyAddress(out addr);   //out?
                    Console.WriteLine("Name is modified, now {0}.", addr.name);
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


        void addAddress(ref Address addr)
        {
            Console.WriteLine("Please Enter name you wish to add:");
            addr.name = Console.ReadLine();
            Console.WriteLine("Please Enter the address for {0}:", addr.name);
            addr.detailaddr = Console.ReadLine();
            Console.WriteLine("Name: {0}, Address: {1} has been added.", addr.name, addr.detailaddr);
        }


        void addAddressV2(Address addr)
        {
            Console.WriteLine("Please Enter name you wish to add:");
            addr.name = Console.ReadLine();
            Console.WriteLine("Please Enter the address for {0}:", addr.name);
            addr.detailaddr = Console.ReadLine();
            Console.WriteLine("Name: {0}, Address: {1} has been added.", addr.name, addr.detailaddr);
        }

        // this is copy
        void AddInt(int a)
        {
            a = a + 3;
        }

        void AddIntV2(ref int a)
        {
            // this version is different from:  void AddInt(int a)
            a = a + 3;
        }

        void deleteAddress(string name)
        {

        }

     //   void viewAddress(params string[] names)
        public void viewAddress(ArrayList addrArray)
        {
            foreach (string name in addrArray)
            {
                Console.WriteLine("Name: {0}, Address: {1}", ((Address)name).Name, ((Address)name).Detailaddr);
            }
            //throw new NotImplementedException();
        }



        void modifyAddress(out Address addr)
        {
            addr = new Address();
            Console.WriteLine("Whose address you wanna to modify? ");
            addr.name = Console.ReadLine();
            Console.WriteLine("Please input the new address for {0}", addr.name);
            addr.detailaddr = Console.ReadLine();

        }

 

        /** The addAdress() method takes a ref parameter. 
          * This means that a reference to the parameter is copied to the method.
          * This reference still refers to the same object on the heap as the orginal reference used in the caller's argument.*/
        
    }
}
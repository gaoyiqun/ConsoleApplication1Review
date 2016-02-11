using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LectureReview3
{
    class AddressBookProgram
    {
        static void Main(string[] args)
        {
            string userChoice;

            List < Address > AddressList = new List<Address>();

            AddressBookProgram ab = new AddressBookProgram();

            do
            {
                userChoice = ab.getChoice();

                ab.makeDecision(userChoice, AddressList);

                Console.Write("press Enter key to continue...");
                Console.ReadLine();
                Console.WriteLine();

            }
            while (userChoice != "Q" && userChoice !="q");

        } 

        private string getChoice()
        {
            string userChoice;

            Console.WriteLine("My Address Book\n");

            Console.WriteLine("A - Add New Address");
            Console.WriteLine("D - Delete Address");
            Console.WriteLine("M - Modify Address");
            Console.WriteLine("V - View Addresses");
            Console.WriteLine("Q - Quit\n");

            Console.WriteLine("Choice (A,D,M,V,or Q): ");

            userChoice = Console.ReadLine();

            return userChoice;

        }

        void makeDecision(string userChoice, List<Address> addressList)
        {
            switch (userChoice)
            {
                case "A":
                case "a":
                    Address addr = new Address();
                    this.addAddress(ref addr);   //ref?
                    addressList.Add(addr);
                    break;
                case "D":
                case "d":
                    this.deleteAddress(addressList);
                    break;
                case "M":
                case "m":
                    
                    this.modifyAddress(addressList);   //out?
                   
                    break;
                case "V":
                case "v":
                    this.viewAddress(addressList);
                    break;
                case "Q":
                case "q":
                    Console.WriteLine("Bye.");
                    break;
                default:
                    Console.WriteLine("{0} is not a valid choice", userChoice);
                    break;
            }

        }

        private void modifyAddress(List<Address> addressList)
        {
            Console.WriteLine("Whose address you want to modify?");

            string mod = Console.ReadLine();

            for (int i = 0; i < addressList.Count; i++)
            {

                do
                {
                    Console.WriteLine("Input the new address for {0}", addressList[i].name);
                    addressList[i].AddrDetail = Console.ReadLine();
                    Console.WriteLine("{0}'s address is modified, now .", addressList[i].name);
                    break;
                } while (mod == addressList[i].name);
                break;
            
            }
            /**
            foreach (Address addr in addressList)
            {
                if (mod == addr.name)
                {
                    Console.WriteLine("Input the new address for {0}", addr.name);
                    addr.AddrDetail=Console.ReadLine();
                    Console.WriteLine("{0}'s address is modified, now .", addr.name);
                    break;
                }
                else
                {
                    Console.WriteLine("{0}'s address information does not exist.", mod);
                }

            }
    **/

        }

        private void viewAddress(List<Address> addressList)
        {
            foreach (Address addr in addressList)
            {
                Console.WriteLine("Name: {0}, Address: {1}", addr.Name, addr.addrDetail);
            }
            
        }

        private void deleteAddress(List<Address> addressList)
        {
            Console.WriteLine("Whose address you want to delete?");

            string del = Console.ReadLine();
           
            foreach (Address addr in addressList)
            {
                if(addr.name == del)
                {
                    addressList.Remove(addr);
                    Console.WriteLine("{0} 's address has been deleted.", del);
                    break;
                }
            }
        }

        private void addAddress(ref Address addr)
        {
            Console.WriteLine("Please Enter name you wish to add:");
            addr.name = Console.ReadLine();
            Console.WriteLine("Please Enter the address for {0}:", addr.name);
            addr.addrDetail = Console.ReadLine();
            Console.WriteLine("Name: {0}, Address: {1} has been added.", addr.name, addr.addrDetail);
        }
    }
}

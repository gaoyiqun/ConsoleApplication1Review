using Lesson05;
using System;

class MethodParameters
{
    public static void Main()
    {
        string userChoice;

        MethodParameters mp = new MethodParameters();

        do
        {
            //show menu and get input from user
            userChoice = mp.getChoice();

            //make a decision based on user's choice
            mp.makeDecision(userChoice);
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



    void makeDecision(string myChoice)
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
                this.addAddress(ref addr);   //ref?
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
                this.viewAddress("Chery", "Joe", "Matt", "Robert");
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

    void viewAddress(params string[] names)
    {
        foreach (string name in names)
        {
            Console.WriteLine("Name: {0}", name);
        }
        //throw new NotImplementedException();
    }

    private void modifyAddress(out Address addr)
    {
        addr = new Address();
        Console.WriteLine("Whose address you wanna to modify? ");
        addr.name = Console.ReadLine();
        Console.WriteLine("Please input the new address for {0}", addr.name);
        addr.address = Console.ReadLine();

    }

    void deleteAddress(string name)
    {
        Console.WriteLine("You wish to delete {0}'s address.", name);
    }


    /** The addAdress() method takes a ref parameter. 
      * This means that a reference to the parameter is copied to the method.
      * This reference still refers to the same object on the heap as the orginal reference used in the caller's argument.*/
    void addAddress(ref Address addr)
    {
        Console.WriteLine("Please Enter name you wish to add:");
        addr.name = Console.ReadLine();
        Console.WriteLine("Please Enter the address for {0}:", addr.name);
        addr.address = Console.ReadLine();
        Console.WriteLine("Name: {0}, Address: {1} has been added.", addr.name, addr.address);
    }
}
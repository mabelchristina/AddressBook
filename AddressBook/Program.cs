using System;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        { 
            AddressBook abd = new AddressBook();
            bool value = false;
            while (!value)
            {
                Console.WriteLine("*********************************************************");
                Console.WriteLine("1.Add member to Contact list \n2.View Members in Contact List\n3.Edit members Contacts list\n4.Delete members Contacts list\n" +
                    "5.Search by name\n6.Exit\n");
                Console.WriteLine("Enter an option:");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        abd.AddMember();
                        break;
                    case 2:
                        abd.ViewContacts();
                        break;
                    case 3:
                        abd.EditDetails();
                        break;
                    case 4:
                        abd.DeleteDetails();
                        break;
                    case 5:
                        abd.SearchDetails();
                        break;
                    case 6:
                        // to exit from main method
                        Console.WriteLine("Exited");
                        return;

                }
            }
        }
    }
}

using System;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            bool value = false;
            int options;
            while (!value)
            {
                Console.WriteLine("1.CreateContacts\n 2.DisplayContact \n 3.EditContacts\n4.Delete Contacts\n5. MultiContacts Addition ");
                options = Convert.ToInt32(Console.ReadLine());
                AddressBook address = new AddressBook();
                switch (options)
                {
                    case 1:
                        address.CreateContacts();
                        break;
                    case 2:
                        address.DisplayContact();
                        break;
                    case 3:
                        address.EditContact();
                        break;
                    case 4:
                        address.DeleteContacts();
                        break;
                    case 5:
                        Console.WriteLine("Enter the number of contact to be added");
                        address.AddMultiContacts(Convert.ToInt32(Console.ReadLine()));
                        break;
                    default:
                        Console.WriteLine("Choose valid option");
                        break;
                }
            }
        }
    }
}

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
                Console.WriteLine("1.CreateContacts\n 2.DisplayContact \n 3.EditContacts\n ");
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
                    default:
                        Console.WriteLine("Choose valid option");
                        break;
                }
            }
        }
    }
}

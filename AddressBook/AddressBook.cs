using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    class AddressBook
    {
        List<Contacts> addcontacts = new List<Contacts>();
        Dictionary<string, List<Contacts>> dictionary = new Dictionary<string, List<Contacts>>();
        public void CreateContacts()
        {
            Contacts contacts = new Contacts();
            Console.WriteLine("Enter Firstname");
            contacts.Firstname = Console.ReadLine();
            Console.WriteLine("Enter Lastname");
            contacts.LastName = Console.ReadLine();
            Console.WriteLine("Enter Address");
            contacts.Address = Console.ReadLine();
            Console.WriteLine("Enter City");
            contacts.City = Console.ReadLine();
            Console.WriteLine("Enter State");
            contacts.State = Console.ReadLine();
            Console.WriteLine("Enter Zipcode");
            contacts.Zip = Console.ReadLine();
            Console.WriteLine("Enter Phonenumber");
            contacts.PhoneNumber = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter Email");
            contacts.Email = Console.ReadLine();
            addcontacts.Add(contacts);
        }
        public void DisplayContact()
        {
            foreach (var data in addcontacts)
            {
                Console.WriteLine("The Contact Details are\n:" + data.Firstname + " " + data.LastName + " " + data.Address + " " + data.City + " " + data.State + " " + data.Zip + " " + data.PhoneNumber + " " + data.Email);
            }
        }
        public void EditContact()
        {
            Console.WriteLine("to edit contact list enter contact firstname");
            string name = Console.ReadLine();
            foreach (var data in addcontacts)
            {
                if (addcontacts.Contains(data))
                {
                    if (data.Firstname.Equals(name))
                    {
                        Console.WriteLine("To edit contacts enter 1.LastName\n 2.Address\n 3.City\n 4.State\n 5.Zip\n 6.PhoneNumber\n 7.Email\n");
                        int options = Convert.ToInt32(Console.ReadLine());
                        switch (options)
                        {
                            case 1:
                                string lastname = Console.ReadLine();
                                data.LastName = lastname;
                                break;
                            case 2:
                                string address = Console.ReadLine();
                                data.Address = address;
                                break;
                            case 3:
                                string city = Console.ReadLine();
                                data.City = city;
                                break;
                            case 4:
                                string state = Console.ReadLine();
                                data.State = state;
                                break;
                            case 5:
                                string zip = Console.ReadLine();
                                data.Zip = zip;
                                break;
                            case 6:
                                int number = Convert.ToInt32(Console.ReadLine());
                                data.PhoneNumber = number;
                                break;
                            case 7:
                                string email = Console.ReadLine();
                                data.Email = email;
                                break;
                            default:
                                Console.WriteLine("choose valid option");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("name doesnt matches");
                    }
                }
            }
            DisplayContact();
        }
        public void DeleteContacts()
        {
            Console.WriteLine("enter first name to delete contact ");
            string name = Console.ReadLine();
            foreach (var data in addcontacts)
            {
                if (data.Firstname.Equals(name))
                {
                    addcontacts.Remove(data);
                    Console.WriteLine("contact deleted successfully");
                }
                else
                {
                    Console.WriteLine("given name contact does not exists");
                }
                       
            }
            DisplayContact();
        }
        public void AddMultiContacts(int n)
        {
            while (n > 0)
            {
                foreach (var data in addcontacts)
                {
                    Console.WriteLine("enter firstname of your contactdetails");
                    string name = Console.ReadLine();
                    if (data.Firstname == name)
                    {
                         Console.WriteLine("enter dictionary name");
                         string dictinaryName = Console.ReadLine();
                         dictionary.Add(dictinaryName, addcontacts);
                    }
                }
                n--;
            }
        }
        public void AddressBookInDictionary()
        {
            Console.WriteLine("Enter the name of Dictionary");
            string name = Console.ReadLine();
            foreach (var contacts in dictionary)
            {
                if (contacts.Key.Contains(name))
                {
                    foreach (var data in contacts.Value)
                    {
                        Console.WriteLine("The Contact Details are\n:" + data.Firstname + " " + data.LastName + " " + data.Address + " " + data.City + " " + data.State + " " + data.Zip + " " + data.PhoneNumber + " " + data.Email);
                    }
                }
            }
        }
    }
    
}

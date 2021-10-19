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
                    "5.Search by name\n6.Count by state or city\n7.Sort Alphabatically\n8. Sort by City ,State or Zip\n" +
                    "9.Read from a file\n 10. Write to file\n" +
                    "11.Read from a csv file\n 12. Write to csv file\n13.Read from a json file\n 14. Write to json file\n15.Exit\n");
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
                        abd.CountByStateOrCity();
                        break;
                    case 7:
                        abd.SortEntriesAlphabetically();
                        break;
                    case 8:
                        abd.SortByCityStateZip();
                        break;
                    case 9:
                       abd.ReadFromFile();
                        break;
                    case 10:
                        abd.WriteToFile();
                        break;
                    case 11:
                        abd.ReadFromCSVFile();
                        break;
                    case 12:
                        abd.WriteToCSVFile();
                        break;
                    case 13:
                        abd.ReadFromJsonFile();
                        break;
                    case 14:
                        abd.WriteToJsonFile();
                        break;
                    case 15:
                        // to exit from main method
                        Console.WriteLine("Exited");
                        return;
                }
            }
        }
    }
}

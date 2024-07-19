using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.Lab2_Q1
{
    internal class ContactListManager
    {
        private List<Contact> contactList = new List<Contact>();

        public void AddContact()
        {
            Console.WriteLine("Enter Contact Number: ");
            int contactNo = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Contact Name: ");
            string contactName = Console.ReadLine();

            contactList.Add(new Contact { ContactNo = contactNo, ContactName = contactName });
            Console.WriteLine("Contact added successfully!");
        }

        public void DisplayContact()
        {
            Console.WriteLine("Enter Contact Number to display: ");
            int contactNo = int.Parse(Console.ReadLine());

            var foundContact = contactList.Find(c => c.ContactNo == contactNo);
            if (foundContact != null)
            {
                Console.WriteLine($"Contact No: {foundContact.ContactNo}");
                Console.WriteLine($"Contact Name: {foundContact.ContactName}");
            }
            else
            {
                Console.WriteLine("Contact not found!");
            }
        }

        public void EditContact()
        {
            Console.WriteLine("Enter Contact Number to edit: ");
            int contactNo = int.Parse(Console.ReadLine());

            var foundContact = contactList.Find(c => c.ContactNo == contactNo);
            if (foundContact != null)
            {
                Console.WriteLine("Enter new Contact Name (leave blank to keep old value): ");
                string newName = Console.ReadLine();
                if (!string.IsNullOrEmpty(newName))
                {
                    foundContact.ContactName = newName;
                }

                Console.WriteLine("Contact details updated successfully!");
            }
            else
            {
                Console.WriteLine("Contact not found!");
            }
        }

        public void ShowAllContacts()
        {
            if (contactList.Count == 0)
            {
                Console.WriteLine("No contacts found in the list!");
            }
            else
            {
                Console.WriteLine("List of Contacts: ");
                foreach (var contact in contactList)
                {
                    Console.WriteLine($"Contact No: {contact.ContactNo}");
                    Console.WriteLine($"Contact Name: {contact.ContactName}");
                    Console.WriteLine("----------");
                }
            }
        }

        public void Run()
        {
            int choice;

            do
            {
                Console.WriteLine("\nContact List Menu");
                Console.WriteLine("1. Add Contact");
                Console.WriteLine("2. Display Contact");
                Console.WriteLine("3. Edit Contact");
                Console.WriteLine("4. Show All Contacts");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Enter your choice: ");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddContact();
                        break;
                    case 2:
                        DisplayContact();
                        break;
                    case 3:
                        EditContact();
                        break;
                    case 4:
                        ShowAllContacts();
                        break;
                    case 5:
                        Console.WriteLine("Exiting Contact List application...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            } while (choice != 5);
        }
    }
}

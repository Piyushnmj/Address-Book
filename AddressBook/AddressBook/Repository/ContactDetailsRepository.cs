using AddressBook.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Repository
{
    internal class ContactDetailsRepository
    {
        Dictionary<string, ContactDetails> contactDetails = new Dictionary<string, ContactDetails>();

        public void AddContactDetails(ContactDetails contactDetail) //using mobile number because it is unique.
        {
            contactDetails.Add(Convert.ToString(contactDetail.MobileNumber), contactDetail);
        }

        public void DisplayContact()
        {
            foreach (var item in contactDetails)
            {
                Console.WriteLine($"\nFirst Name::{item.Value.FirstName}");
                Console.WriteLine($"Last Name::{item.Value.LastName}");
                Console.WriteLine($"Mobile Number::{item.Value.MobileNumber}");
                Console.WriteLine($"EMail::{item.Value.EMail}");
                Console.WriteLine($"Address::{item.Value.Address}");
                Console.WriteLine($"City::{item.Value.City}");
                Console.WriteLine($"State::{item.Value.State}");
                Console.WriteLine($"Zip::{item.Value.Zip}");
            }
        }
    }
}

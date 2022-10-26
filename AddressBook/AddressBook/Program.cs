using AddressBook.Model;
using AddressBook.Repository;

namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book");           

            Console.WriteLine("\nEnter First Name: ");
            string? firstName = Console.ReadLine();

            Console.WriteLine("\nEnter Last Name: ");
            string? lastName = Console.ReadLine();

            Console.WriteLine("\nEnter Mobile Number: ");
            string? mobileNumber = Console.ReadLine();

            Console.WriteLine("\nEnter EMail: ");
            string? eMail = Console.ReadLine();

            Console.WriteLine("\nEnter Address: ");
            string? address = Console.ReadLine();

            Console.WriteLine("\nEnter City: ");
            string? city = Console.ReadLine();

            Console.WriteLine("\nEnter State: ");
            string? state = Console.ReadLine();

            Console.WriteLine("\nEnter Zip: ");
            string? zip = Console.ReadLine();

            ContactDetails contactDetail = new ContactDetails()
            {
                FirstName = firstName,
                LastName = lastName,
                MobileNumber = Convert.ToInt64(mobileNumber),
                EMail = eMail,
                Address = address,
                City = city,
                State = state,
                Zip = Convert.ToInt32(zip)
            };

            ContactDetailsRepository contactDetails = new ContactDetailsRepository();
            contactDetails.AddContactDetails(contactDetail);
            contactDetails.DisplayContact();
            Console.ReadLine();
        }
    }

}


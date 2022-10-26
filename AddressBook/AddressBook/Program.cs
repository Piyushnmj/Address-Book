using AddressBook.Model;
using AddressBook.Repository;

namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book");
            ContactDetailsRepository contactDetails = new ContactDetailsRepository();
            contactDetails.AddContactDetails("Virat", "Kohli", 9009009321, "viratkohli@gmail.com", "Worli", "Mumbai", "Maharashtra", 400018);
            contactDetails.DisplayContact();
            Console.ReadLine();
        }
    }
}


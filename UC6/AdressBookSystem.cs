using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adressbook1
{
    internal class AdressBookSystem
    {
        public Dictionary<string, AdressBook> adressBooks = new Dictionary<string, AdressBook>();
        public void AddAddressBook()
        {
            AdressBook adressBook = new AdressBook();
            adressBook.AddMultipleContact();
            Console.WriteLine("enter the addressbook name");
            string addressName = Convert.ToString(Console.ReadLine());
            adressBooks.Add(addressName.ToLower(), adressBook);

        }
    }
}

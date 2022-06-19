namespace AdressBook1
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("welcome to AdressBook");
            AdressBookSystem adressBookSystem = new AdressBookSystem();
            string command1 = "";

            while (command1 != "exit")
            {
                Console.WriteLine("enter the option: 1.Add AdressBook 2.Edit AddressBook 3.Remove AddressBook");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        adressBookSystem.AddAddressBook();
                        break;
                    case 2:
                        Console.WriteLine("enter the addressbook name you want to edit");
                        string addressBookName = Console.ReadLine();


                        if (adressBookSystem.adressBooks.ContainsKey(addressBookName.ToLower()))
                        {


                            string command = "";

                            while (command != "exit")
                            {

                                Console.WriteLine("Please enter a command add,edit,remove,display,multipleperson: ");
                                command = Console.ReadLine().ToLower();


                                switch (command)
                                {
                                    case "add":


                                        adressBookSystem.adressBooks[addressBookName.ToLower()].AddPerson();
                                        break;
                                    case "edit":
                                        adressBookSystem.adressBooks[addressBookName.ToLower()].EditContact();
                                        break;
                                    case "remove":
                                        adressBookSystem.adressBooks[addressBookName.ToLower()].RemoveContact();
                                        break;
                                    case "display":
                                        adressBookSystem.adressBooks[addressBookName.ToLower()].Display();
                                        break;
                                    case "multipleperson":
                                        adressBookSystem.adressBooks[addressBookName.ToLower()].AddMultipleContact();
                                        break;
                                    default:
                                        command = "exit";
                                        break;
                                }
                            }
                        }
                        break;
                    default:
                        command1 = "exit";
                        break;





                }

            }
        }
    }
}

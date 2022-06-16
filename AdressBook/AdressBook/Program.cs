namespace AddressBook
{
    class program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Welcome to AddressBook");

            AdressBook address = new AdressBook();

            string command = "";

            while (command != "exit")
            {

                Console.WriteLine("Please enter a command add,edit,remove,display,multiplperson: ");
                command = Console.ReadLine().ToLower();

                switch (command)
                {
                    case "add":


                        address.AddPerson();
                        break;

                    case "edit":
                        address.EditContact();
                        break;
                    case "remove":
                        address.RemoveContact();
                        break;
                    case "display":
                        address.Display();
                        break;
                }
            }

        }
    }
}


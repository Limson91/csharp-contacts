class Program
{
    // Array di contatti
    static string[] contacts = new string[50];

    // Contatore contatti presenti
    static int contactsCount = 0;

    static void Main()
    {
        System.Console.WriteLine();
        System.Console.WriteLine(" --- Select a number! ---");
        System.Console.WriteLine();

        while ( true ) {
            System.Console.WriteLine("1. Insert new contact");
            System.Console.WriteLine("2. View contacts");
            System.Console.WriteLine("3. Search Contact");
            string choose = System.Console.ReadLine();

            switch ( choose ) {
                case "1":
                AddContact();
                break;

                case "2":
                ViewContact();
                break;

                case "3":
                SearchContact();
                break;
            }
        }
    }

    static void AddContact()
    {
        if(contactsCount < contacts.Length) {
            System.Console.WriteLine("Add contact name: ");

            string name = System.Console.ReadLine();
            contacts[contactsCount++] = name;
            System.Console.WriteLine("Successfully added!");
            System.Console.WriteLine();
        }
    }

    static void ViewContact() 
    {
        System.Console.WriteLine("Contacts list: ");

        for (int i = 0; i < contactsCount; i++)
        {
            System.Console.WriteLine(contacts[i]);
        }

        System.Console.WriteLine();
    }

    static void SearchContact()
    {
        System.Console.WriteLine("Search name: ");
        string name = System.Console.ReadLine();
        bool foundName = false;

        for (int i = 0; i < contactsCount; i++)
        {
            if (contacts[i] == name) {
                System.Console.WriteLine($"{name} has been found!");
                System.Console.WriteLine();

                foundName = true;
                break;
            }
        }

        if ( !foundName ) {
            System.Console.WriteLine($"{name} not found!");
            System.Console.WriteLine();
        }
    }
}
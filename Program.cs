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
            System.Console.WriteLine("1. Insert New Contact");
            System.Console.WriteLine("2. View Contacts");
            System.Console.WriteLine("3. Search Contact");
            System.Console.WriteLine("4. Delete Contact");
            System.Console.WriteLine("5. Exit");
            System.Console.WriteLine();
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

                case "4":
                DeleteContact();
                break;

                case "5":
                return;

                default:
                System.Console.WriteLine("Command not valid!");
                break;
            }
        }
    }

    static void AddContact()
    {
        if(contactsCount < contacts.Length) {
            System.Console.Write("Add contact name: ");

            string name = System.Console.ReadLine();
            contacts[contactsCount++] = name;
            System.Console.WriteLine($"\"{name}\" Successfully added!");
            System.Console.WriteLine();
        }
    }

    static void ViewContact() 
    {
        System.Console.WriteLine("Contacts list: ");
        System.Console.WriteLine();

        for (int i = 0; i < contactsCount; i++)
        {
            System.Console.WriteLine(contacts[i]);
        }

        System.Console.WriteLine();
    }

    static void SearchContact()
    {
        System.Console.Write("Search name: ");
        string name = System.Console.ReadLine();
        bool foundName = false;

        for (int i = 0; i < contactsCount; i++)
        {
            if (contacts[i] == name) {
                System.Console.Write($"\"{name}\" has been found!");
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

    static void DeleteContact()
    {
        System.Console.Write("Delete Contact: ");
        string name = System.Console.ReadLine();
        bool found = false;

        for (int i = 0; i < contactsCount; i++)
        {
            if( contacts[i] == name ) 
            {
                for (int k = i; k < contactsCount; k++) 
                {
                    contacts[k] = contacts[k + 1];
                }

                contacts[--contactsCount] = null;
                found = true;
                System.Console.WriteLine($"\"{name}\" has been deleted!");
                break;
            }
        }

        if ( !found ) {
            System.Console.WriteLine($"\"{name}\" not found!");
        }
    }
}
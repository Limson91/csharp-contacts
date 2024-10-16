class Program
{
    // Array di contatti
    static string[] contacts = new string[50];

    // Contatore contatti presenti
    static int contactsCount = 0;

    static void Main()
    {
        System.Console.WriteLine(" --- Select a number! ---");
        System.Console.WriteLine();

        while ( true ) {
            System.Console.WriteLine("1. Insert new contact");
            string choose = System.Console.ReadLine();

            switch ( choose ) {
                case "1":
                AddContact();
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
        }
    }
}
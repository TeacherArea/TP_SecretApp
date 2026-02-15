namespace SecretApp
{
    internal class Program
    {
        static string[] userNames = { "Pelle", "Stina", "Ali" };
        static string[] userPasswords = { "1234", "12345", "123456" };
        static bool userLoggedIn = false;

        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till Secret App");

            bool runProgram = true;
            while (runProgram)
            {
                Menu();
                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    if (choice == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("INLOGGNING\n");
                        LoggIn();
                    }

                    else if (choice == 2)
                    {
                        Console.Clear();
                        Console.WriteLine("LÄGG TILL ANVÄNDARE\n");
                        AddUser();
                    }

                    else if (choice == 3)
                    {
                        Console.Clear();
                        Console.WriteLine("TA BORT ANVÄNDARE\n");
                        DeleteUser();
                    }

                    else if (choice == 4)
                    {
                        Console.Clear();
                        Console.WriteLine("ÄNDRA LÖSENORD\n");
                        ChangePassword();
                    }

                    else if (choice == 5)
                    {
                        Console.Clear();
                        Console.WriteLine("ANVÄNDARLISTA\n");
                        ShowUsers();
                    }

                    else if (choice == 9)
                    {
                        Console.Clear();
                        Menu();
                    }

                    else if (choice == 0)
                    {
                        runProgram = false;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Någon sådan funktion finns inte än. Välj korrekt heltal i menyn.");
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Välj ett heltal ur menyn.");
                }
            }
            Console.WriteLine("Tack för att du använder Secret App. Välkommen tillbaka!");
            Thread.Sleep(3000);
        }

        static void LoggIn()
        {
            Console.Clear();
            Console.WriteLine("Inloggning\n");
            Console.Write("Namn: ");
            string name = Console.ReadLine();
            Console.Write("Lösenord: ");
            string password = Console.ReadLine();

            int i = 0;
            while (i < userNames.Length)
            {
                if (userNames[i] == name)
                {
                    if (userPasswords[i] == password)
                    {
                        Console.WriteLine("Välkommen " + name);
                        userLoggedIn = true;
                        break;
                    }

                    else
                    {
                        Console.WriteLine("Felaktigt lösenord");
                    }
                }
                i++;
            }

            if (Array.IndexOf(userNames, name) == -1)
            {
                Console.WriteLine("Inget sådant namn finns i listan. För att lägga till en avändare, välj i menyn.");
            }
        }

        // TODO AddUser är inte klar
        static void AddUser()
        {
            Console.WriteLine("Hello from AddUser()");
        }

        // TODO DeleteUser är inte klar
        static void DeleteUser()
        {
            Console.WriteLine("Hello from DeleteUser()");
        }

        static void ShowUsers()
        {
            if (userLoggedIn)
            {
                Console.Clear();
                Console.WriteLine("Alla namn i listan:\n");
                int i = 0;
                while (i < userNames.Length)
                {
                    Console.WriteLine(userNames[i].ToUpper());
                    i++;
                }
            }
            else
            {
                NotLoggedInMessage();
            }
        }

        // TODO ChangePssword är inte klar
        static void ChangePassword()
        {
            Console.WriteLine("Hello från Change Password");
        }

        static void Menu()
        {
            Console.WriteLine(
                "\n* * * * * * * * * * *\n\n" +
                "Meny\n\n" +
                "1. Logga in\n" +
                "2. Lägg till användare\n" +
                "3. Ta bort användare\n" +
                "4. Ändra lösenord\n" +
                "5. Visa användarlistan\n" +
                "9. Visa menyn\n" +
                "0. Avsluta / logga ut\n\n" +
                "* * * * * * * * * * *\n"
                );
        }

        static void NotLoggedInMessage()
        {
            Console.WriteLine("Du har inte access till denna funktionalitet. Logga in först.");
        }
    }
}

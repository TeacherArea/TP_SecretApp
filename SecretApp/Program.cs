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
                        LoggIn();
                    }

                    else if (choice == 2)
                    {
                        AddUser();
                    }

                    else if (choice == 3)
                    {
                        DeleteUser();
                    }

                    else if (choice == 4)
                    {
                        ChangePassword();
                    }

                    else if (choice == 5)
                    {
                        ShowUsers();
                    }

                    else if (choice == 9)
                    {
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
            Console.WriteLine("Tack för att du använder mitt program. Hej då");
            Thread.Sleep(3000);
        }

        // TODO LoggIn är inte klar
        static void LoggIn()
        {
            Console.WriteLine("Hello från LoggIn().");
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
            Console.WriteLine("Hello from ShowUser()");
        }

        // TODO ChangePssword är inte klar
        static void ChangePassword()
        {
            Console.WriteLine("Hello från ChangePassword()");
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
    }
}
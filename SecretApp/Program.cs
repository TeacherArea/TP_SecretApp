using System.Diagnostics;

namespace SecretApp
{
    internal class Program
    {
        static string[] userNamesArray = { "Pelle", "Stina", "Ali" };
        static string[] userPasswordArray = { "1234", "12345", "123456" };
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
            Console.Write("Namn: ");
            string name = Console.ReadLine();
            Console.Write("Lösenord: ");
            string password = Console.ReadLine();

            int i = 0;
            while (i < userNamesArray.Length)
            {
                if (userNamesArray[i] == name)
                {
                    if (userPasswordArray[i] == password)
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

            if (Array.IndexOf(userNamesArray, name) == -1) // Array.IndexOf returnerar -1 om den inte hittar en match
            {
                Console.WriteLine("Inget sådant namn finns i listan. För att lägga till en avändare, välj i menyn.");
            }
        }

        // TODO Ändra så att enbart inloggade kan använda AddUser().
        static void AddUser()
        {
            bool run = true;
            while (run)
            {
                Console.Write("Namn: ");
                string name = Console.ReadLine();
                Console.Write("Lösenord: ");
                string password = Console.ReadLine();

                string[] userNamesTemp = new string[userNamesArray.Length + 1];
                string[] userPasswordsTemp = new string[userPasswordArray.Length + 1];

                if (!String.IsNullOrWhiteSpace(name) && !String.IsNullOrWhiteSpace(password))
                {
                    int i = 0;
                    while (i < userNamesArray.Length)
                    {

                        userNamesTemp[i] = userNamesArray[i];
                        userPasswordsTemp[i] = userPasswordArray[i];
                        i++;
                    }
                    userNamesTemp[userNamesTemp.Length - 1] = name;
                    userPasswordsTemp[userPasswordsTemp.Length - 1] = password;

                    userNamesArray = userNamesTemp;
                    userPasswordArray = userPasswordsTemp;

                    run = false;
                }
                else
                {
                    EmptyInputsMessage();
                }
            }
        }

        // TODO Ändra så att enbart vissa inloggade kan använda DeleteUser().
        static void DeleteUser()
        {
            bool run = true;
            while (run)
            {
                Console.Write("Namn: ");
                string name = Console.ReadLine();

                int hit = Array.IndexOf(userNamesArray, name);

                if (!String.IsNullOrWhiteSpace(name) && hit != -1)
                {
                    string[] userNamesTemp = new string[userNamesArray.Length - 1];
                    string[] userPasswordsTemp = new string[userPasswordArray.Length - 1];

                    int i = 0;
                    int j = 0;
                    while (i < userNamesArray.Length)
                    {
                        if (i == hit)
                        {
                            i++;
                            continue;
                        }
                        userNamesTemp[j] = userNamesArray[i];
                        userPasswordsTemp[j] = userPasswordArray[i];
                        i++;
                        j++;
                    }
                    userNamesArray = userNamesTemp;
                    userPasswordArray = userPasswordsTemp;

                    run = false;
                }
                else
                {
                    EmptyInputsMessage();
                }
            }
        }

        static void ShowUsers()
        {
            if (userLoggedIn)
            {
                int i = 0;
                while (i < userNamesArray.Length)
                {
                    Console.WriteLine($"Användare: {userNamesArray[i].ToUpper()}. Lösenord: {userPasswordArray[i]}");
                    i++;
                }
            }
            else
            {
                int i = 0;
                while (i < userNamesArray.Length)
                {
                    Console.WriteLine(userNamesArray[i].ToUpper());
                    i++;
                }
            }
        }

        // TODO Gör klart ChangePassword
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


        // TODO Använd NotLoggedInMessage() i en else, för de som försöker nå en metod utan att vara inloggade
        static void NotLoggedInMessage()
        {
            Console.WriteLine("Du har inte access till denna funktionalitet. Logga in först.");
        }

        static void EmptyInputsMessage()
        {
            Console.WriteLine("Antingen så har du glömt skriva in ditt namn eller ditt lösenord. Försök igen!");
        }
    }
}

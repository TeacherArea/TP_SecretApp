namespace SecretApp
{
    internal class Program
    {
        static void Main()
        {
            string[] names = { "Pelle", "Stina", "Ali" };
            string[] passwords = { "secret1", "secret2", "secret3" };

            bool run = true;

            while (run)
            {
                Console.WriteLine("\nThe SecretApp! Avsluta med \"Yes\". Vill du det?");
                string userChoice = Console.ReadLine().ToLower();

                if (userChoice != "yes")
                {
                    Console.Write("Skriv in ditt namn: ");
                    string name = Console.ReadLine();
                    Console.Write("Lösenord: ");
                    string password = Console.ReadLine();

                    if (name == names[0] && password == passwords[0])
                    {
                        Console.WriteLine("Välkommen " + name);
                        run = false;
                    }
                    else
                    {
                        Console.WriteLine($"Namnet {name} med lösenordet {password} kunde inte hittas. Försök igen.");
                    }
                }
                else
                {
                    run = false;
                }
            }
            Console.WriteLine("Tack för att du använde denna app. Hej då!");
        }
    }
}

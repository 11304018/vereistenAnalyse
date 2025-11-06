namespace DemoVereistenanalyse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string gebruikersnaam = "Admin";
            string wachtwoord = "Passwoord123";
            int tries = 0;
           
            while (tries < 3)
            {
                Console.Write("Geef de gebruikersnaam in: ");
                string inputGebruikersnaam = Console.ReadLine();
                Console.Write("Geef het wachtwoord in: ");
                string inputWachtwoord = Console.ReadLine();

                if (inputGebruikersnaam == gebruikersnaam && inputWachtwoord == wachtwoord)
                {
                    Console.WriteLine($"Welkom {inputGebruikersnaam}!");
                    return;
                }
                tries++;
                Console.WriteLine($"Foutieve login. \n{3 - tries} pogingen over.");
            }
            Console.WriteLine("Te veel pogingen. Toegang geweigerd. ");
        }
    }
}

namespace DemoVereistenanalyse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef de gebruikersnaam in: ");
            string inputGebruikersnaam = Console.ReadLine();
            Console.Write("Geef het wachtwoord in: ");
            string inputWachtwoord = Console.ReadLine();

            string gebruikersnaam = "Admin";
            string wachtwoord = "Passwoord123";

            if (inputGebruikersnaam == gebruikersnaam && inputWachtwoord == wachtwoord)
            {
                Console.WriteLine($"Welkom {inputGebruikersnaam}!");
                return;
            }
        }
    }
}

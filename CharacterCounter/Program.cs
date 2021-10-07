using System;

namespace CharacterCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnimi ja perekonnanimi
            //programm kuvab kasutaja eesnime ja perekonnanime pikkust kokku
            //Length omadust kasutamata

            Console.WriteLine("Sisesta oma eesnimi:");
            string username = Console.ReadLine();
            Console.WriteLine("Sisesta oma perekonnanimi:");
            string lastname = Console.ReadLine();
            string fullname = $"{username} {lastname}";

            int charCounter = 0;
            foreach (char c in fullname)
            {
                charCounter++;
            }
            Console.WriteLine($"Nimes {fullname} on {charCounter} sõna pikk.");
                
        }
    }
}

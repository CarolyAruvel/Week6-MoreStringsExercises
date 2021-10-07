using System;

namespace SubstituteCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajalt sisestada eesnimi ja perekonnanimi
            //programm asendab kõik 'a' tähed kasutaja nimes tärniga (*)
            //programm kuvab tulemust konsoolis

            Console.WriteLine("Siseta oma nimi:");
            string username = Console.ReadLine();
            Console.WriteLine("Sisesta oma perekonnanimi:");
            string lastname = Console.ReadLine();
            string fullname = $"{username} {lastname}";

            fullname = fullname.Replace('a', '*');

            Console.WriteLine(fullname);

        }
    }
}

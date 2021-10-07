using System;

namespace MoreStringsExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab sõna "racecar" tagurpidi

            string RaceC = "racecar";

            for(int i = RaceC.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(RaceC[i]);
            }
        }
    }
}

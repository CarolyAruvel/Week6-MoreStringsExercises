using System;

namespace ForEachLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab sõna "Hello World" pikkust length omaduse kasutamata

            string HelloW = "Hello World";
            int charCounter = 0;

            foreach (char c in HelloW)
            {
                charCounter++;
            }
            Console.WriteLine($"Lause pikkus on {HelloW} on {charCounter}.");
        }
    }
}

using System;

namespace WordCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            /* programm kuvab, mitu sõna on lauses "Hello, World"
             string HelloW = "Hello, World!";

             //while

             int i = 0;
             int WordCounter = 1;

             while(i < HelloW.Length)
             {
                 if(HelloW[i]== ' ')
                 {
                     WordCounter++;
                 }

                 i++;
             }
             Console.WriteLine($"Lauses {HelloW} on -{WordCounter} sõna ");
             */

            int WordCounter = 1;

            string HelloW = "Hello, World!";
            for (int i = 0; i < HelloW.Length; i++)    
            if (HelloW[i] == ' ')
            {
                    WordCounter++;
            }
            Console.WriteLine($"Lauses {HelloW} on -{WordCounter} sõna ");
        }
    }
}

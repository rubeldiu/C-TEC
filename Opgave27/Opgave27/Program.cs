using System;

namespace Opgave27
{
    class Program
    {
        static void Main(string[] args)
        {
            double pris = 0;
            Console.WriteLine("Hvis du køber for mere end 1000 Dkk, får du 5 procent rabat : ");
            Console.Write("Venligst indtast pris : ");
            pris = double.Parse(Console.ReadLine());

            if (pris > 1000)
            {
                pris = pris * 0.95;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"Du får 5 procent rabat. Prisen er {pris}");

            }
            else
            {
                Console.Write($"Din betaling på {pris} og du får ingen rabat");
            }
            Console.ReadKey();

        }
    }
}

using System;

namespace OpgaveRect14
{
    class Program
    {
        static void Main(string[] args)
        {
            int højde, bredde, arealet;

            Console.Write("Venligst, indtast høje : ");
            højde = int.Parse(Console.ReadLine());

            Console.Write("Venligst, indtast bredde : ");
            bredde = int.Parse(Console.ReadLine());

            arealet = højde * bredde;

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine($"Arealet på rektangel bliver : {arealet}");
            Console.ReadKey();

        }
    }
}

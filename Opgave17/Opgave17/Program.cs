using System;

namespace Opgave17
{
    class Program
    {
        static void Main(string[] args)
        {
            double højde, grundlinje, c, omkredsen;

            Console.Write("Venligst, indtast højde : ");
            højde = double.Parse(Console.ReadLine());

            Console.Write("Venligst, indtast grundlinje : ");
            grundlinje = double.Parse(Console.ReadLine());

            c = Math.Sqrt(Math.Pow(højde, 2) + Math.Pow(grundlinje, 2));
            omkredsen = højde + grundlinje + c;


            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("omkredsen af en Trekant bliver : {0:N2}", omkredsen);

            Console.ReadKey();
        }
    }
}

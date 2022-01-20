using System;

namespace Opgave16
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius, omkredsen, arealet;

            Console.Write("Venligst, indtast radius : ");
            radius = int.Parse(Console.ReadLine());

            omkredsen = 2 * radius * Math.PI;
            //arealet= Math.PI * radius * radius;
            arealet = Math.PI * Math.Pow(radius,2);
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine($"omkredsen af en cirkel bliver : {omkredsen:N2}");
            Console.WriteLine($"arealet af en cirkel bliver : {arealet:N2}");
            Console.ReadKey();

        }
    }
}

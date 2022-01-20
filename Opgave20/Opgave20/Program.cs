using System;

namespace Opgave20
{
    class Program
    {
        static void Main(string[] args)
        {
            int tal1,tal2;
            //Skriver på skærmen
            Console.Write(" indtaste første tal: ");
            tal1 = int.Parse(Console.ReadLine());

            //Skriver på skærmen
            Console.Write(" indtaste andet tal: ");
            tal2 = int.Parse(Console.ReadLine());

            if (tal1 > tal2)
            {
                Console.Write($" {tal1} er størst ");

            }
            if (tal2 > tal1)
            {
                Console.Write($" {tal2} er størst ");

            }
            if (tal2 == tal1)
            {
                Console.Write($" {tal1} og {tal2} er samme tal ");

            }
            // vent på tastetryk
            Console.ReadKey();
        }
    }
}

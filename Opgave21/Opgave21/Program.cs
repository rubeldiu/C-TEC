using System;

namespace Opgave21
{
    class Program
    {
        static void Main(string[] args)
        {
            char type;
            //Skriver på skærmen
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" Er du medlem af en forening: ");
            type = char.Parse(Console.ReadLine());


            if (type == 'j')
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($" Du får 10 procent i rabat ");

            }
            if (type == 'n')
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($" Du opnår ikke 10 procent i rabat ");

            }

            if (type != 'j' && type != 'n')
            {
                Console.WriteLine(" *************Forkert Indtast *******************");
                Console.Beep(440, 2000);
                Console.Beep(440, 2000);
                Console.Beep(440, 2000);
            }

            // vent på tastetryk
            Console.ReadKey();
        }
    }
}

using System;

namespace Opgave19
{
    class Program
    {
        static void Main(string[] args)
        {
            int alder;
            //Skriver på skærmen
            Console.Write(" indtaste din alder: ");
            alder = int.Parse(Console.ReadLine());

            if (alder >= 18)
            {
                Console.Write($" Du er {alder} År gammel og  Du er godkendt til kreditaftaler ");

            }
            else
            {
                Console.Write($" Du er {alder} År gammel og  Du kan ikke blive godkendt til kreditaftaler ");
            }

            // vent på tastetryk
            Console.ReadKey();
        }
    }
}

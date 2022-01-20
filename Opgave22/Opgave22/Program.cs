using System;

namespace Opgave22
{
    class Program
    {
        static void Main(string[] args)
        {
            int alder;
            //Skriver på skærmen
            Console.Write(" indtaste din alder: ");
            alder = int.Parse(Console.ReadLine());

            if (alder < 18)
            {
                Console.Write($" Du er {alder} År gammel og  billetprisen være 45 kroner ");

            }
            if (alder >= 18 && alder <=65)
            {
                Console.Write($" Du er {alder} År gammel og  billetprisen være 75 kroner ");

            }
            if (alder >65)
            {
                Console.Write($" Du er {alder} År gammel og  billetprisen være 35 kroner ");

            }
           
            // vent på tastetryk
            Console.ReadKey();
        }
    }
}

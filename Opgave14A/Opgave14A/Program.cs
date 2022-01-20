using System;

namespace Opgave14A
{
    class Program
    {
        static void Main(string[] args)
        {
            //arealet af trekanten  = base X height / 2

            
            //rens consolskærmen
            Console.Clear();
           

            //Skriver på skærmen
            Console.Write(" Indtast grundlinje er trekants: ");
           double grundlinje =double.Parse(Console.ReadLine());

            Console.Write(" Indtast højde er trekants: "); 
            double højde = double.Parse(Console.ReadLine());

            // beregning 

            double arealetAfTrekanten = grundlinje * højde/2;
            // udskriver til skærmen
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" Arealet af trekanten er {0}", arealetAfTrekanten);

            // vent på tastetryk
            Console.ReadKey();

        }
    }
}

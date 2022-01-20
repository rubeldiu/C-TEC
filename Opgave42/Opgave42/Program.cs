using System;

namespace Opgave42
{
    class Program
    {
        static void Main(string[] args)
        {
            string tast;
            Console.WriteLine("Tryk på 1 på Rektangel ,  2  på cirkel  eller 3 på trekant på tastaturet: ");
            tast = Console.ReadLine();

            switch (tast)
            {
                case "1":
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
                    break;
                case "2":
                    {
                        double radius, omkredsen, arealet;

                        Console.Write("Venligst, indtast radius : ");
                        radius = int.Parse(Console.ReadLine());

                        omkredsen = 2 * radius * Math.PI;
                        //arealet= Math.PI * radius * radius;
                        arealet = Math.PI * Math.Pow(radius, 2);
                        Console.ForegroundColor = ConsoleColor.Green;

                        Console.WriteLine($"omkredsen af en cirkel bliver : {omkredsen:N2}");
                        Console.WriteLine($"arealet af en cirkel bliver : {arealet:N2}");
                        Console.ReadKey();

                    }
                    break;
                case "3":
                    {
                        //arealet af trekanten  = base X height / 2


                        
                        //Skriver på skærmen
                        Console.Write(" Indtast grundlinje er trekants: ");
                        double grundlinje = double.Parse(Console.ReadLine());

                        Console.Write(" Indtast højde er trekants: ");
                        double højde = double.Parse(Console.ReadLine());

                        // beregning 

                        double arealetAfTrekanten = grundlinje * højde / 2;
                        // udskriver til skærmen
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(" Arealet af trekanten er {0}", arealetAfTrekanten);

                        // vent på tastetryk
                        Console.ReadKey();
                    }
                    break;
                default:
                    Console.WriteLine("Du har ikke tastet 1,2 eller 3 tast return");
                    break;
            }
            Console.ReadKey();

        }
    }
}

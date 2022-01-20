using System;

namespace Opgave46
{
    class Program
    {
        static void Main(string[] args)
        {
            string vælg, zone;
            double pris = 0, bZonePris = 0, rZonePris = 0, gZonePris = 0, lZonePris = 0;
            int antal;
            Console.WriteLine("{0,20}", "Der var engang");

            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.BackgroundColor = ConsoleColor.White;


                Console.WriteLine("Ballerup svømmehal Priser :");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\t1 -- Blå zone pris kr. 190");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t2 -- Rød zone pris kr. 250");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\t3 -- Gul zone pris kr. 280");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\t4 -- Lyserød zone pris kr. 320");
                Console.ResetColor();
                Console.WriteLine("\t5 -- Samlet pris");
                Console.Write("Indtast dit valg (0 for at afslutte) : ");
                vælg = Console.ReadLine();


                switch (vælg)
                {
                    case "1":
                        {
                            do
                            {
                                Console.WriteLine("Hvilken plads A/B ? :  ");
                                zone = Console.ReadLine().ToUpper();

                            } while (zone != "A" && zone != "B");
                            Console.WriteLine("Hvor mange ? :");
                            antal = int.Parse(Console.ReadLine());
                            bZonePris = antal * 190;
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Pris er {0} DKK, {1} zone  {2} plads .", bZonePris, "Blå", zone);
                            Console.ResetColor();
                            Console.ReadKey();
                        }
                        break;
                    case "2":
                        {
                            do
                            {
                                Console.WriteLine("Hvilken Terrasa A/B ? :  ");
                                zone = Console.ReadLine().ToUpper();

                            } while (zone != "A" && zone != "B");
                            Console.WriteLine("Hvor mange ? :");
                            antal = int.Parse(Console.ReadLine());
                            rZonePris = antal * 250;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Pris er {0} DKK, {1} zone Terrasa {2}  .", rZonePris, "Rød", zone);
                            Console.ResetColor();
                            Console.ReadKey();
                        }
                        break;

                    case "3":
                        {
                            do
                            {
                                Console.WriteLine("Hvilken Parket A/B ? :  ");
                                zone = Console.ReadLine().ToUpper();

                            } while (zone != "A" && zone != "B");
                            Console.WriteLine("Hvor mange ? :");
                            antal = int.Parse(Console.ReadLine());
                            gZonePris = antal * 280;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Pris er {0} DKK, {1} zone .", gZonePris, "Gul", zone);
                            Console.ResetColor();
                            Console.ReadKey();
                        }
                        break;
                    case "4":
                        {

                            Console.WriteLine("Hvor mange ? :");
                            antal = int.Parse(Console.ReadLine());
                            lZonePris = antal * 250;
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Pris er {0} DKK, {1} zone  .", lZonePris, "Lyserød");
                            Console.ResetColor();
                            Console.ReadKey();
                        }
                        break;
                    case "5":
                        {
                            pris = bZonePris + gZonePris + rZonePris + lZonePris;
                            if (pris <= 0)
                            {
                                Console.WriteLine("Du har ikke købt nogen billet");
                            }
                            else
                            {
                                Console.WriteLine("Total pris : {0} DKK", pris);
                            }
                            Console.ReadKey();
                        }
                        break;
                    default:
                        if (vælg != "0")
                        {
                            Console.WriteLine("Du har ikke tastet 1,2,3,4 eller 5 tast return");
                            Console.ReadKey();
                        }

                        break;
                }
            } while (vælg != "0");
            Console.WriteLine("Du har nu afsluttet program");
            Console.ReadKey();

        }
    }
}

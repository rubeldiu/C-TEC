using System;

namespace BurgerOpgave
{
    class Program
    {
        static void Main(string[] args)
        {
            string menuvalg;
            double pris=0, totalpris,rabat=0;
            int antal;
            //Overskrift
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("B U R G E R R E S T A U R A N T");
            Console.Write(" ");
            Console.ResetColor();


            //Inddatering af oplysninger om menuvalg og antal stykker

            do
            {
                Console.WriteLine("Indast den menu du vil købe ");
                Console.WriteLine("Vælg mellem B,BP eller BPC :");
                menuvalg = Console.ReadLine().ToLower();

            } while (menuvalg!="b" && menuvalg!="bp" && menuvalg!="bpc" );

            do
            {
                Console.WriteLine("Hvor mange {0} vil du købe ? ", menuvalg);
                antal = int.Parse(Console.ReadLine());

            } while (antal>100 || antal<1);
            

            // tideling af pris afhængig af menuvalg
            if (menuvalg == "b") pris = 35;
            if (menuvalg == "bp") pris = 45;
            if (menuvalg == "bpc") pris = 60;

            totalpris = antal * pris;


            Console.WriteLine("Prisen fo din bestilling bliver kr . {0:N2}", totalpris);

            //punkt a - beregning af eventuel rabat

            if (antal > 15)
            {
                rabat = totalpris * 0.08;
                Console.WriteLine("Rabaten er {0} kr.", rabat);
            }

            //punkt b - Totalprisen is USD
            //Console.WriteLine("Total Prisen i USD er {0:N2}", totalpris / (634.32 / 100));

            Console.ReadKey();






        }
    }
}

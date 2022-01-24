using System;

namespace Burgerrestauranten
{
    class Program
    {
        static void Main(string[] args)
        {
            //erklæring af variable
            string svar;
            double totalpris = 0, rabat=0, afterRabatPris=0;
            int antalt;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(32, 2);
            Console.WriteLine("Burger Restauranten");
            Console.ResetColor();
            
            Console.WriteLine("MENU koster ");
            Console.WriteLine("Burger(B) koster 35 DKK, Burger med Pommes Frites(BP) Koster 45 DKK ,Burger med Pommes Frites og Kola (BPC) Koster 60 DKK .");
            //inddatering af antal variable
            do
            {
                Console.Write("Onsker du Burger(B),Burger med Pommes Frites(BP) eller Burger med Pommes Frites og Kola (BPC) ? (B/BP/BPC) : ");
                svar = Console.ReadLine().ToUpper();

            } while (svar != "B" && svar != "BP" && svar != "BPC");

            do
            {
                Console.Write("Hvor mange menuer vil du købe ? :");
                antalt = int.Parse(Console.ReadLine());

            } while (antalt<0);

            //beregning
            if (svar == "B") totalpris = 35 * antalt;
            if (svar == "BP") totalpris = 45 * antalt;
            if (svar == "BPC") totalpris = 60 * antalt;

            //Udskrivning
            if (antalt>15)
            {
                rabat = totalpris * 0.08;
                afterRabatPris = totalpris - rabat;
                calculation();
                Console.WriteLine("Totalprisen før rabat {0}", totalpris);
                Console.Write("Du skal betaller {0:N2} DKK here rabat er {1:N2} DKK", afterRabatPris, rabat);
            }

            else
            {
                calculation();
                Console.Write("Du skal  betaller {0:N2} DKK ", totalpris);

            }

            Console.ReadKey();

        }
        public static void calculation()
        {
            Console.Write("Beregning ");
            for (int i = 0; i < 4; i++)
            {
                System.Threading.Thread.Sleep(1000);
                Console.Write("*");
                
            }
            Console.WriteLine(" ");
        }
       
}
}

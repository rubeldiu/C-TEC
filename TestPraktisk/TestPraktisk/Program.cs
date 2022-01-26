using System;

namespace TestPraktisk
{
    class Program
    {
        static void Main(string[] args)
        {
            //erklæring af variable
            string svar;
            double totalpris = 0, rabat = 0, afterRabatPris = 0;
            int antalt;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(32, 2);
            Console.WriteLine("Billetter til Rosenborg Slot");
            Console.ResetColor();

            Console.WriteLine("Billetter Pris ");
            Console.WriteLine("Almindelig (AB) billet koster 75 DKK, Almindelig billet med kronjuvelerne (ABK) billet koster 125 DKK ,kronjuvelerne (BK) billet Koster 25 DKK .");
            //inddatering af antal variable
            do
            {
                Console.Write("Onsker du hvilken typer ? (AB/ABK/BK) : ");
                svar = Console.ReadLine().ToUpper();

            } while (svar != "AB" && svar != "ABK" && svar != "BK");

            do
            {
                Console.Write("Hvor mange billeter vil du købe ? :");
                antalt = int.Parse(Console.ReadLine());

            } while (antalt < 0);

            //beregning
            if (svar == "AB") totalpris = 75 * antalt;
            if (svar == "ABK") totalpris = 125 * antalt;
            if (svar == "BK") totalpris = 25 * antalt;

            //Udskrivning
            if (antalt > 25)
            {
                rabat = totalpris * 0.05;
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
                Console.Write("#");

            }
            Console.WriteLine(" ");
        }

    }
}

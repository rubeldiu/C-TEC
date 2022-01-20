using System;

namespace FodboldklubbenOpgave
{
    class Program
    {
        static void Main(string[] args)
        {

            //initialisere variabel
            int antalvoksenbiletter=0, antalbørnebilletter=0, totalbilletter = 0;
            double Totalpris = 0, pris = 0, rabat = 0, kursen= 625.45,usd=0;
            string medlem;
            string indtast1, indtast2;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(32, 2);
            Console.WriteLine("Fodboldklubben Billetsalgsservice");
            Console.ResetColor();
            Console.WriteLine("");
            Console.SetCursorPosition(80, 3);
            Console.WriteLine("Dags Dato : {0:D}", DateTime.Now);

            //Call fo Sunday Method 
             Sunday();

            Console.WriteLine("");
            Console.WriteLine("");
           // Console.SetCursorPosition(10, 8);
            Console.WriteLine("En børnebillet koster 30 kr. og En voksenbillet koster 65 kr.");
            //Console.SetCursorPosition(10, 9);
            Console.WriteLine("Man kan højst bestille 10 børnebilletter og 10 voksenbilletter.");
            Console.WriteLine("");
            Console.WriteLine("");
           

            do
            {
                do
                {
                    Console.Write("Hvor mange børnebillet du vil købe,højst bestille 10 :");
                    indtast1 = Console.ReadLine();

                } while (!int.TryParse(indtast1,out _));
              
                antalbørnebilletter = int.Parse(indtast1);

            } while (antalbørnebilletter >= 11 || antalbørnebilletter <= -1);

            //Tjek for max 10 billetter
            do
            {
                do
                {
                    Console.Write("Hvor mange voksenbillet du vil købe,højst bestille 10 :");
                    indtast2 = Console.ReadLine();

                } while (!int.TryParse(indtast2,out _));
              
                antalvoksenbiletter = int.Parse(indtast2);

            } while (antalvoksenbiletter >=11 ||antalvoksenbiletter <=-1);

            //Beregn samlet pris

            Totalpris = antalbørnebilletter * 30 + antalvoksenbiletter * 65;

            //Beregn samlet biletter

            totalbilletter = antalvoksenbiletter + antalbørnebilletter;

            // Check for medlem af foreningsgruppe
            do
            {
                Console.Write("Er du medlem af klubbens foreningsgruppe (Y/N) ? : ");
                medlem = Console.ReadLine().ToUpper();

            } while (medlem !="Y" && medlem!="N");

            // Hvis Y, så har du rabat
            if (medlem=="Y")
            {
                //Beregn rabat pris
                rabat = Totalpris * 0.10;
                pris = Totalpris - rabat;
                //Converter DKK til USD
                usd = Math.Round(pris /(kursen/100));
                //call Calculation Method
                Calculation();
                Console.WriteLine("");
                Console.WriteLine("Din pris er {0:N2} DKK eller {1} USD here Rabat {2:N2} DKK", pris, usd, rabat);
                Console.WriteLine("Du bestille i alt {0} billetter.", totalbilletter);
                if (antalbørnebilletter>0)
                {
                    Console.WriteLine("Du bestiller  {0} Børne billetter.", antalbørnebilletter);
                    BilletNo(antalbørnebilletter);
                }
                if (antalvoksenbiletter > 0)
                {
                    Console.WriteLine("Du bestiller {0} Voksen billetter.", antalvoksenbiletter);
                    BilletNo(antalvoksenbiletter);
                }
                
            }
            // Hvis N, så har du ikke noget rabat
            else
            {
                //Converter DKK til USD 
                usd = Math.Round(Totalpris/(kursen/100));
                //call Calculation Method
                Calculation();
                Console.WriteLine("");
                Console.WriteLine("Din pris er {0:N2} DKK eller {1} USD ", Totalpris, usd);
                Console.WriteLine("Du bestille i alt {0} billetter .", totalbilletter);
                Console.WriteLine("Du har ikke nogen rabat");
                if (antalbørnebilletter > 0)
                {
                    Console.WriteLine("Du bestiller  {0} Børne billetter.", antalbørnebilletter);
                    BilletNo(antalbørnebilletter);
                }
                if (antalvoksenbiletter > 0)
                {
                    Console.WriteLine("Du bestiller {0} Voksen billetter.", antalvoksenbiletter);
                    BilletNo(antalvoksenbiletter);
                }
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("******************************* Mange Tak ********************************************");
            Console.ReadKey();


        }

        //Calculate Next Sunday 

        public static void Sunday()
        {
            var date = DateTime.Now;
            DateTime nextSunday = date.AddDays(7 - (int)date.DayOfWeek);
            Console.SetCursorPosition(80, 4);
            Console.WriteLine("Next Match : {0:D}", nextSunday);
        }

        //Calculate 
        public static void Calculation()
        {
            Console.Write("Beregning");
            for (int i = 0; i < 4; i++)
            {
                System.Threading.Thread.Sleep(1000);
                Console.Write(".");
               
            }
            Console.WriteLine("");
        }

        //Print Ticket No ...
        public static void BilletNo(int antalt)
        {
            Console.Write("Billet Nr : ");
            for (int i = 0; i < antalt; i++)
            {
                System.Threading.Thread.Sleep(1000);
                Console.Write(DateTime.Now.ToString("E" + "MMddmmssff"+ "  "));

            }
            Console.WriteLine("");
        }


    }
    }


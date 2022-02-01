using System;

namespace ProjectProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }

        // Menu 

         public static bool MainMenu()
        {
            Console.Clear();
            Console.SetCursorPosition(10, 2);
            Console.WriteLine("<<< Carsten Mørch Information Systems - Gæste-refistrering v 1.0 >>> ");
            Console.WriteLine();
            Console.Write("\t [O] Operet ");
            Console.Write("\t [F] Find ");
            Console.Write("\t [V] Vis alle ");
            Console.WriteLine("\t [Q] Afslut :  ");
            Console.Write("\t Vælg funktion : ");
           

            switch (Console.ReadLine().ToUpper())
            {
                case "O":
                    OperetFile();
                    return true;
                case "F":
                    FindFile();
                    return true;
                case "V":
                    VissAlleFile();
                    return true;
                case "Q":
                    return false;
                default:
                    return true;
            }
        }


        //Opret Fil 
        public static void OperetFile()
        {
            string telefonnummer, navn, adresse, postnr,by, email, skrivtilfilen;
            bool telefonnummergodkendt, telefonnummerfundet;
            int tele=0;
            Console.WriteLine("");
            Console.WriteLine("");
            //do
            //{
            //    do
            //    {
            //        Console.Write("\tTelefon nr : ");
            //        telefonnummer = Console.ReadLine();

            //    } while (int.TryParse(telefonnummer,out _)==false);
            //    tele = int.Parse(telefonnummer);

            //} while (tele < 10000000 || tele > 99999999);
            //Console.Write("Ok ! Kan oprettes ");

            do
            {
                telefonnummerfundet = false;
                telefonnummergodkendt = false;
                do
                {
                    //godkendelsesdel
                    Console.Write("\tTelefon nr : ");
                    telefonnummer = Console.ReadLine();
                    if (int.TryParse(telefonnummer,out _)&& (telefonnummer.Length==8))
                    {
                        telefonnummergodkendt = true;

                    }
                    else
                    {
                        Console.WriteLine("Telefonnummer ikke korrekt format - tryk på en tast");
                        Console.ReadKey();
                    }

                } while (!telefonnummergodkendt);

                //Søgefunktion
                //hente fra filen
                string[] lines = System.IO.File.ReadAllLines(@"C:\Users\shoha\OneDrive\Desktop\TEC\C#\Programming\brugere.txt");

                foreach (string line in lines)
                {
                    if (line.Contains(telefonnummer))
                    {
                        telefonnummerfundet = true;
                    }

                }

                if (telefonnummerfundet)
                {
                    Console.WriteLine("Nummer eksistere i forvejen");
                    Console.ReadKey();
                }


            } while (telefonnummerfundet);
            Console.WriteLine("Du har nu været igennem de obligatoriske tjek af nummer og kan nu oprette");
            


            do
            {
                Console.Write("\tNavn : ");
                navn = Console.ReadLine();

            } while (navn == "");

            Console.Write("\tAdresse : ");
            adresse = Console.ReadLine();

            Console.Write("\tPostnr : ");
            postnr = Console.ReadLine();

            Console.Write("\tBy : ");
            by = Console.ReadLine();

            Console.Write("\tEmail : ");
            email = Console.ReadLine();

            
            skrivtilfilen = telefonnummer + ", " + navn + ", " + adresse + ", " + postnr + ", " + by + ", " + email ;


            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\shoha\OneDrive\Desktop\TEC\C#\Programming\brugere.txt", true))
            {
                file.WriteLine(skrivtilfilen);
            }

            Console.WriteLine("\tOplysninger gemmes ..... ");

            Console.ReadKey();
        }

        //Find Fil 
        public static void FindFile()
        {
            //hente fra file
            string findtekts;
            bool found = false;
            Console.WriteLine("");
            Console.WriteLine("");

            Console.Write("\tIndtast hvad du vil søge efter : ");
            findtekts = Console.ReadLine();

            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\shoha\OneDrive\Desktop\TEC\C#\Programming\brugere.txt");

           

            foreach (string line in lines)
            {
                //Looking for some specific text
               
                if (line.Contains(findtekts))
                {
                    Console.WriteLine("\tResultatet af din søgning");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    found = true;
                    Console.WriteLine("\t" + line);
                }
              

                Console.ResetColor();
               
            }

            if (found==false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\tIkke Fundet !!!!  - Tryk en tast !");
                Console.ResetColor();
            }


           
            Console.ReadKey();
        }

        //Vis Alle fra Fil 
        public static void VissAlleFile()
        {
            //hente fra file
           
            int tæller = 0;

           
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\shoha\OneDrive\Desktop\TEC\C#\Programming\brugere.txt");

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine($"\tDer er i alt {lines.Length} liner i datafilen");
            Console.WriteLine("\tInhold af databasen");
            Console.WriteLine("");
            Console.WriteLine("");

            foreach (string line in lines)
            {
                
                if (tæller == 15) //For Pagignation
                {
                    Console.Write("\tTryk tast for næste side Next Side ->");
                    Console.ReadKey();
                    tæller = 0;
                    Console.Clear();

                }
                else
                {
                    Console.WriteLine("\t" + line);
                    tæller++;

                }
            }
            Console.WriteLine(" ");
            Console.WriteLine("\tIkke mere at vise - Tryk en tast ! ");
            Console.ReadKey();
        }


    }
}

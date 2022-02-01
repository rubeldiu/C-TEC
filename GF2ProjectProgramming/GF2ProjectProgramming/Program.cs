using System;

namespace GF2ProjectProgramming
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

        public static bool MainMenu()
        {
            Console.Clear();
            Console.SetCursorPosition(10, 2);
            Console.WriteLine("<<< Carsten Mørch Information System - Gæste-refistrering v 1.0 >>>");
            Console.WriteLine();
            Console.Write("\t [O] Operet ");
            Console.Write("\t [F] Find ");
            Console.Write("\t [V] Vis alle ");
            Console.WriteLine("\t [Q] Vis Afslut  ");
            Console.Write("\t Vælg function : ");

            switch (Console.ReadLine().ToUpper())
            {
                case "O":
                    OperateFile();
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
        public static void OperateFile()
        {
            string telefonenummer, navn, adresse, postnr, by, email, skrivtilfilen;
            bool telefonnummergodkendt, telefonnummerfundet;
            Console.WriteLine("");
            Console.WriteLine("");
            do
            {
                telefonnummerfundet = false;
                telefonnummergodkendt = false;

                do
                {
                    Console.Write("\tTelefon nr : ");
                    telefonenummer = Console.ReadLine();
                    if (int.TryParse(telefonenummer,out _) && (telefonenummer.Length==8))
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
                //Hente fra filen
                string[] lines = System.IO.File.ReadAllLines(@"C:\Users\shoha\OneDrive\Desktop\TEC\C#\Programming\text.txt");

                foreach (string line in lines)
                {
                    if (line.Contains(telefonenummer))
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
            } while (navn=="");
            Console.Write("\tAddress : ");
            adresse = Console.ReadLine();
            Console.Write("\tPostnr : ");
            postnr = Console.ReadLine();
            Console.Write("\tBy : ");
            by = Console.ReadLine();
            Console.Write("\tEmail : ");
            email = Console.ReadLine();

            skrivtilfilen = telefonenummer + " , " + navn + " , " + adresse + " ," + postnr + " , " + by + " , " + email;

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\shoha\OneDrive\Desktop\TEC\C#\Programming\text.txt", true))
            {
                file.WriteLine(skrivtilfilen);
            }
            Console.WriteLine("\tOplysninger gemmes .....");

            Console.ReadKey();
        }

        //Find Fil 
        public static void FindFile()
        {
            string findtekts;
            bool found = false;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("\tIndtast hvad du vil søge efter :");
            findtekts = Console.ReadLine();
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\shoha\OneDrive\Desktop\TEC\C#\Programming\text.txt");

            foreach (string line in lines)
            {
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

        //Viss Alle Fil 
        public static void VissAlleFile()
        {
            //hente fra fil
            int tæller = 0;
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\shoha\OneDrive\Desktop\TEC\C#\Programming\text.txt");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine($"\tDer er i alt {lines.Length} liner i datafilen");
            Console.WriteLine("\tInhold af databasen");
            Console.WriteLine("");
            Console.WriteLine("");

            foreach (string line in lines)
            {
                if (tæller==15)
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
            Console.WriteLine("");
            Console.WriteLine("\t Ikke mere at vise - Tryk en tast !");
            Console.ReadKey();
        }
    }
}

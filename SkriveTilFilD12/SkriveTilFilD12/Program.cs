using System;

namespace SkriveTilFilD12
{
    class Program
    {
        static void Main(string[] args)

        {
            string telefonnummer, fornavn, efternavn, skrivtilfilen;

            Console.WriteLine("Indtast dit telefonenummer");
            telefonnummer = Console.ReadLine();

            Console.WriteLine("Indtast dit Fornavn");
            fornavn = Console.ReadLine();

            Console.WriteLine("Indtast dit Efternavn");
            efternavn = Console.ReadLine();
            skrivtilfilen = telefonnummer +" " + fornavn + " " + efternavn;


            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\shoha\OneDrive\Desktop\TEC\C#\Programming\foldbold.txt", true))
            {
                file.WriteLine(skrivtilfilen);
            }

            Console.WriteLine("Nu er brugeren oprettet i filen");

            // Read the file as one string.
            string text = System.IO.File.ReadAllText(@"C:\Users\shoha\OneDrive\Desktop\TEC\C#\Programming\foldbold.txt");

            // Display the file contents to the console. Variable text is a string.
            System.Console.WriteLine("Contents of WriteText.txt = {0}", text);

            Console.ReadKey();
        }
    }
}

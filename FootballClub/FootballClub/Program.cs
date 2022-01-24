using System;

namespace FootballClub
{
    class Program
    {
        static void Main(string[] args)
        {
            //erklæring af variable

            int antalbørnebilletter, antalvoksnenbilletter;
            double totalpris,rabat,kurs= 625.45;

            Console.SetCursorPosition(40, 2);
            Console.WriteLine("{0:D}", DateTime.Now);
            do
            {
                //inddatering af antal variable
                do
                {
                    Console.Write("Indtast hvor mange børnebilletter du vil købe : ");

                    antalbørnebilletter = int.Parse(Console.ReadLine());

                } while (antalbørnebilletter > 10 || antalbørnebilletter < 0);


                do
                {
                    Console.Write("Indtast hvor mange voksenbilletter du vil købe : ");

                    antalvoksnenbilletter = int.Parse(Console.ReadLine());

                } while (antalvoksnenbilletter > 10 || antalvoksnenbilletter < 0);

            } while (antalbørnebilletter + antalvoksnenbilletter == 0);


            //beregning

            totalpris = antalbørnebilletter * 30 + antalvoksnenbilletter * 65;




            //Udskrivning

            Console.Write("Du skal betale kr. {0:N2}", totalpris);
            Console.WriteLine("Prisen i USD bliver {0}",Math.Round( totalpris / (kurs / 100)));
            Console.WriteLine("Du har i alt købt {0} antal biletter", antalbørnebilletter + antalvoksnenbilletter);

            Console.Write("Er du medlem af klubbens foreningsgruppe j/n : ");
            char svar = char.Parse(Console.ReadLine());

            if (svar=='j')
            {
                rabat = totalpris * 0.10;
                Console.Write("Rabatten ud gør {0}", rabat);
                Console.ReadKey();
            }

            Console.ReadKey();


        }
    }
}

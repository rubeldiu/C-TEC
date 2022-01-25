using System;

namespace DemoTextFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string telefonnummer, fornavn, efternavn, sammenlangt;

            telefonnummer = "12345678";
            fornavn = "Hamidu";
            efternavn = "Islam";

            sammenlangt = telefonnummer +" "+ fornavn +" "+ efternavn;

            Console.WriteLine(sammenlangt);
            Console.ReadKey();
        }
    }
}

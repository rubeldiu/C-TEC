using System;

namespace TestOpgaveWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            string password;

            Console.Write("Indtast et password som er mindst 5 tegn: ");
            password = Console.ReadLine();

            while (password.Length < 5)
            {
                Console.WriteLine("Password skal være minimum 5 tegn");
                Console.WriteLine("Prøv igen. Indtast password");
                password = Console.ReadLine();
            }
            Console.Write("Mange TAK");
            Console.ReadKey();

        }
    }
}

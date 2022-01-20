using System;

namespace Opgave39
{
    class Program
    {
        static void Main(string[] args)
        {
            string password;
            int forsøg = 0;

            do
            {
                Console.Write("Indtast et password som er mindst 5 tegn og du kan max får 5 forsøg : ");
                password = Console.ReadLine();
                forsøg++;

            } while (forsøg <5 && password.Length < 5);


            if(forsøg < 5 && password.Length <= 5)
            {
                Console.Write("Mange TAK din password er godkend, efter {0} antal forsøg ", forsøg);
            }
            else
            {
                Console.Write("Din password er ikke  godkend, efter {0} antal forsøg ", forsøg);
            }
           
           
            Console.ReadKey();

        }
    }
}

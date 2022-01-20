using System;

namespace ArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // sum erklæres og tildeles værdien 0
            double sum = 0;

            // Arrayet erklæres med plads til 10
            double[] højder = new double[10];

            // Arrayet løbes igennem med i som tæller
            // og for hver gennemløb læses en værdi fra tastaturet
            for (int i = 0; i <= 9; i++)
            {
                Console.Write("Indtast højde på person nr. {0}: ", i + 1);
                højder[i] = Convert.ToDouble(Console.ReadLine());
                // sum forøges hele tiden med den nye værdi der indtastes
                sum = sum + højder[i];
            }

            // Arrayet løbes igennem een gang til og udskriver samtlige index
            for (int i = 0; i <= 9; i++)
            {
                Console.WriteLine("Højden på person nr. {0} er {1}", i + 1, højder[i]);
            }

            // til sidst beregnes gennmsnittet 
            Console.Write("Gennemsnittet er {0}", sum / 10);
            Console.ReadKey();

        }
    }
}

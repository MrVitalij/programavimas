using System;

namespace uzduotis24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite kiek duomenų norite įvesti į masyvą:");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            Console.WriteLine("Įveskite masyvo elementus:");
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            int suma1 = 0, suma2 = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] % 2 == 0) // Lyginis elementas
                {
                    suma1 += arr[i];
                }

                if (i % 2 != 0) // Nelyginis indeksas
                {
                    suma2 += arr[i];
                }
            }

            Console.WriteLine($"Suma1 (lyginių elementų suma) = {suma1}");
            Console.WriteLine($"Suma2 (nelyginių indeksų elementų suma) = {suma2}");
        }
    }
}
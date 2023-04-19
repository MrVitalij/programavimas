using System;

namespace uzduotis21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Masyvo kūrimas su duomenimis
            int[] studentuPazymiai = { 10, 9, 8, 7, 6 };

            // Masyvo kūrimas nusirodant dydį ir priskiriant reikšmes
            string[] masinuMarkes = new string[3];
            masinuMarkes[0] = "Audi";
            masinuMarkes[1] = "BMW";
            masinuMarkes[2] = "Mercedes";

            // Duomenų išvedimas
            Console.WriteLine("Studentų pažymiai:");
            for (int i = 0; i < studentuPazymiai.Length; i++)
            {
                Console.WriteLine("Studentas Nr. " + (i + 1) + ": " + studentuPazymiai[i]);
            }

            Console.WriteLine("\nMašinų markės:");
            for (int i = 0; i < masinuMarkes.Length; i++)
            {
                Console.WriteLine("Mašina Nr. " + (i + 1) + ": " + masinuMarkes[i]);
            }
        }
    }
        
}

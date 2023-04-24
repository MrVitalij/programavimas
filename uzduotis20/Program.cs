using System;

namespace uzduotis20
{
    internal class Program

        // Pitagoro teorema
    {
        static void Main(string[] args)
        
        { 

            Console.OutputEncoding = System.Text.Encoding.UTF8;

        
            Console.WriteLine("Įveskite pirmojo statinio ilgį:");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Įveskite antrojo statinio ilgį:");
            double b = Convert.ToDouble(Console.ReadLine());

            double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

            Console.WriteLine($"Įžambinės ilgis yra: {c}");
            Console.WriteLine();

        }
    }
}

using System;

namespace uzduotis20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite pirmojo statinio ilgį:");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Įveskite antrojo statinio ilgį:");
            double b = Convert.ToDouble(Console.ReadLine());

            double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

            Console.WriteLine($"Įžambinės ilgis yra: {c}");
        }
    }
}

using System;

namespace uzduotis05
{
    internal class Program
    {
        static void Main(string[] args)

        {   Console.OutputEncoding = System.Text.Encoding.UTF8;

            // 1 dalis

            Console.Write("Įveskite pirmą skaičių: ");
            int skaicius1 = int.Parse(Console.ReadLine());

            Console.Write("Įveskite antrą skaičių: ");
            int skaicius2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Suma: {skaicius1 + skaicius2}");
            Console.WriteLine($"Skirtumas: {skaicius1 - skaicius2}");
            Console.WriteLine($"Sandauga: {skaicius1 * skaicius2}");
            Console.WriteLine($"Dalmenys: {skaicius1 / skaicius2}");
            Console.WriteLine();

            // 2 dalis

            Console.Write("Įveskite skaičių: ");
            double skaicius = double.Parse(Console.ReadLine());

            double kvadratas = Math.Pow(skaicius, 2);
            double kubas = Math.Pow(skaicius, 3);

            Console.WriteLine($"Skaičius: {skaicius}");
            Console.WriteLine($"Kvadratas: {kvadratas}");
            Console.WriteLine($"Kubas: {kubas}");
            Console.WriteLine();

            // 3 dalis

            Console.Write("Įveskite pirmąjį skaičių: ");
            double skaiciu1 = double.Parse(Console.ReadLine());

            Console.Write("Įveskite antrąjį skaičių: ");
            double skaiciu2 = double.Parse(Console.ReadLine());

            Console.Write("Įveskite trečiąjį skaičių: ");
            double skaiciu3 = double.Parse(Console.ReadLine());

            double sandauga = skaiciu1 * skaiciu2 * skaiciu3;

            Console.WriteLine($"Sandauga: {sandauga}");
            Console.WriteLine();
        }
    }
}

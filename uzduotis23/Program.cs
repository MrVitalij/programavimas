using System;

namespace uzduotis23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            double vidutinesKuroSanaudos = 6.5; // Automobilio vidutinės kuro sąnaudos 100 km
            double[] keliones = { 150, 200, 75, 120, 80 }; // Masyvas su skirtingose kelionėse nuvažiuotų kilometrų rodmenimis

            double trumpiausiaKelione = keliones[0];
            double ilgiausiaKelione = keliones[0];
            double bendriKilometrai = 0;

            for (int i = 0; i < keliones.Length; i++)
            {
                if (keliones[i] < trumpiausiaKelione)
                {
                    trumpiausiaKelione = keliones[i];
                }

                if (keliones[i] > ilgiausiaKelione)
                {
                    ilgiausiaKelione = keliones[i];
                }

                bendriKilometrai += keliones[i];
            }

            double bendrosKuroSanaudos = (bendriKilometrai * vidutinesKuroSanaudos) / 100;

            Console.WriteLine($"Trumpiausia kelionė: {trumpiausiaKelione} km");
            Console.WriteLine($"Ilgiausia kelionė: {ilgiausiaKelione} km");
            Console.WriteLine($"Bendros kuro sąnaudos: {bendrosKuroSanaudos} l");
        }
    }
}
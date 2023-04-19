using System;
using System.Linq;

namespace uzduotis25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //didžiausio ir mažiausio pažymio įvedimas

            Console.WriteLine("Įveskite 5 pažymius atskirtus tarpu:");
            string input = Console.ReadLine();
            int[] pazymiai = input.Split(' ').Select(int.Parse).ToArray();

            int didziausiasPazymys = pazymiai[0];
            for (int i = 1; i < pazymiai.Length; i++)
            {
                if (pazymiai[i] > didziausiasPazymys && pazymiai[i] <= 10)
                {
                    didziausiasPazymys = pazymiai[i];
                }
            }
            Console.WriteLine("Didžiausias pažymys: " + didziausiasPazymys);

            Console.WriteLine("Įveskite 5 pažymius atskirtus kableliu:");
            input = Console.ReadLine();
            pazymiai = input.Split(',').Select(int.Parse).ToArray();

            int maziausiasPazymys = pazymiai[0];
            for (int i = 1; i < pazymiai.Length; i++)
            {
                if (pazymiai[i] < maziausiasPazymys && pazymiai[i] >= 0)
                {
                    maziausiasPazymys = pazymiai[i];
                }
            }
            Console.WriteLine("Mažiausias pažymys: " + maziausiasPazymys);
        }
    }
}
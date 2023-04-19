using System;
using System.Collections.Generic;
using System.Linq;


namespace uzduotis26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Sugeneruokite atsitiktinio dydžio sąrašą, kurį užpildykite atsitiktiniais  skaičiais nuo 1 iki 100. Raskite:
            // mažiausią skaičių;
            // didžiausią skaičių;
            // vidurkį;
            // kiek skaičių yra žemesni už vidurkį;
            // lyginių skaičių sumą;
            // Liepkite vartotojui pasirinkti kiek studentų pažymių nori suvesti į sąrašą.
            // didžiausią pažymį;
            // mažiausią pažymį;
            // vidurkį;

            Random rand = new Random();
            List<int> numbers = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                numbers.Add(rand.Next(1, 101));
            }

            int min = numbers.Min();
            int max = numbers.Max();
            double average = numbers.Average();
            int belowAverage = numbers.Count(x => x < average);
            int evenSum = numbers.Where(x => x % 2 == 0).Sum();

            Console.WriteLine("Mažiausias skaičius: " + min);
            Console.WriteLine("Didžiausias skaičius: " + max);
            Console.WriteLine("Vidurkis: " + average);
            Console.WriteLine("Skaičių žemiau vidurkio: " + belowAverage);
            Console.WriteLine("Lyginių skaičių suma: " + evenSum);

            Console.WriteLine("Įveskite studentų skaičių:");
            int studentCount = int.Parse(Console.ReadLine());
            List<int> grades = new List<int>();

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine("Įveskite " + (i + 1) + "-ojo studento pažymį:");
                int grade = int.Parse(Console.ReadLine());
                grades.Add(grade);
            }

            int minGrade = grades.Min();
            int maxGrade = grades.Max();
            double averageGrade = grades.Average();

            Console.WriteLine("Mažiausias pažymys: " + minGrade);
            Console.WriteLine("Didžiausias pažymys: " + maxGrade);
            Console.WriteLine("Vidutinis pažymys: " + averageGrade);
        }
    }
}

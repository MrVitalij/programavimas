using System;

namespace uzduotis22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Savaitės temperatūrų rodmenų masyvas
            int[] temperatūros = { 15, 20, 25, 18, 22, 30, 10 };

            int minTemp = temperatūros[0];
            int maxTemp = temperatūros[0];
            double avgTemp = 0;
            int belowAvgCount = 0;
            int aboveAvgCount = 0;

            // Rasti žemiausią, didžiausią ir vidurkį
            foreach (int temp in temperatūros)
            {
                if (temp < minTemp) minTemp = temp;
                if (temp > maxTemp) maxTemp = temp;
                avgTemp += temp;
            }
            avgTemp /= temperatūros.Length;

            // Rasti temperatūrų kiekius žemiau ir aukščiau už vidurkį
            foreach (int temp in temperatūros)
            {
                if (temp < avgTemp) belowAvgCount++;
                if (temp > avgTemp) aboveAvgCount++;
            }

            Console.WriteLine("Žemiausia temperatūra: " + minTemp);
            Console.WriteLine("Didžiausia temperatūra: " + maxTemp);
            Console.WriteLine("Vidutinė temperatūra: " + avgTemp);
            Console.WriteLine("Temperatūrų, esančių žemiau už vidurkį, kiekis: " + belowAvgCount);
            Console.WriteLine("Temperatūrų, esančių aukščiau už vidurkį, kiekis: " + aboveAvgCount);

            // Studentų pažymių masyvas
            int[] grades = { 10, 8, 5, 3, 7, 10, 2, 9 };

            int bestGrade = grades[0];
            int tensCount = 0;
            int negativeCount = 0;
            double avgGrade = 0;

            // Rasti geriausią pažymį, dešimtukų kiekį, neigiamų pažymių kiekį ir vidurkį
            foreach (int grade in grades)
            {
                if (grade > bestGrade) bestGrade = grade;
                if (grade == 10) tensCount++;
                if (grade < 4) negativeCount++;
                avgGrade += grade;
            }
            avgGrade /= grades.Length;

            Console.WriteLine("Geriausias pažymys: " + bestGrade);
            Console.WriteLine("Mokinių, gavusių dešimtukus, kiekis: " + tensCount);
            Console.WriteLine("Mokinių, gavusių neigiamą pažymį, kiekis: " + negativeCount);
            Console.WriteLine("Pažymių vidurkis: " + avgGrade);
        }
    }
}

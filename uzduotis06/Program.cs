using System;

namespace uzduotis06
{
    internal class Program

                // padaryta naudojant chatgpt
    {
        static void Main(string[] args)

        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

                // 1 dalis
        
            int skaicius = 5;
            for (int i = 0; i <= 10; i++)
            {
            Console.WriteLine("{0} * {1} = {2}", skaicius, i, skaicius * i);
            }

                // 2 dalis

            int skaiciu = 36; // Sveikasis skaičius su dviženklio reikšme
            int pirmasSkaitmuo = skaiciu / 10; // Išskiriame pirmą skaitmenį
            int antrasSkaitmuo = skaiciu % 10; // Išskiriame antrą skaitmenį
            int sandauga = pirmasSkaitmuo * antrasSkaitmuo; // Skaitmenų sandauga
            Console.WriteLine("Skaitmenų sandauga: " + sandauga);
        }
    }
}
        
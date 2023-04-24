using System;

namespace uzduotis12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //didziausias skaicius

            Console.WriteLine("Įveskite pirmą skaičių:");
            int skaicius1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Įveskite antrą skaičių:");
            int skaicius2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Įveskite trečią skaičių:");
            int skaicius3 = Convert.ToInt32(Console.ReadLine());

            int didziausias;

            if (skaicius1 > skaicius2 && skaicius1 > skaicius3)
            {
                didziausias = skaicius1;
            }
            else if (skaicius2 > skaicius1 && skaicius2 > skaicius3)
            {
                didziausias = skaicius2;
            }
            else
            {
                didziausias = skaicius3;
            }

            Console.WriteLine("Didžiausias skaičius yra: " + didziausias);
            Console.WriteLine();


            //egzamino rezultato reziai


            Console.WriteLine("Įveskite egzamino rezultatą: ");
            double rezultatas = double.Parse(Console.ReadLine());

            if (rezultatas >= 8 && rezultatas <= 10)
            {
                Console.WriteLine("Gautas rezultatas yra tarp 8 ir 10.");
            }
            else if (rezultatas >= 5 && rezultatas < 8)
            {
                Console.WriteLine("Gautas rezultatas yra tarp 5 ir 8.");
            }
            else if (rezultatas < 5)
            {
                Console.WriteLine("Gautas rezultatas yra mažesnis nei 5.");
            }
            else
            {
                Console.WriteLine("Neteisingai įvestas rezultatas.");
            }

            //skaiciu patikrinimas

            {
                Console.WriteLine("Įveskite pirmą skaičių:");
                int pirmasSkaicius = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Įveskite antrą skaičių:");
                int antrasSkaicius = Convert.ToInt32(Console.ReadLine());

                if (pirmasSkaicius > antrasSkaicius || pirmasSkaicius == 0)
                {
                    Console.WriteLine("Pirmas skaičius yra didesnis už antrąjį, arba yra lygus 0.");
                }

                if (antrasSkaicius > pirmasSkaicius || antrasSkaicius == 5)
                {
                    Console.WriteLine("Antras skaičius yra didesnis už pirmąjį, arba yra lygus 5.");
                }

                if (pirmasSkaicius > antrasSkaicius && pirmasSkaicius == 20)
                {
                    Console.WriteLine("Pirmas skaičius yra didesnis už antrąjį ir yra lygus 20.");
                }

                if (antrasSkaicius > pirmasSkaicius && antrasSkaicius < 100)
                {
                    Console.WriteLine("Antras skaičius yra didesnis už pirmąjį ir yra mažesnis už 100.");
                }
            }
        }
    }
}






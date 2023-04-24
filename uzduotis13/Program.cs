using System;


namespace uzduotis13
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //skaiciu patikrinimas naudojant switch

            Console.WriteLine("Įveskite tris skaičius:");
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());

            switch (number1)
            {
                case 1:
                    Console.WriteLine("Visų trijų skaičių suma: " + (number1 + number2 + number3));
                    break;
                case 2:
                    Console.WriteLine("Pirmo ir trečio skaičių skirtumas: " + (number1 - number3));
                    break;
                case 3:
                    Console.WriteLine("Antro ir trečio skaičių sandauga: " + (number2 * number3));
                    break;
                default:
                    Console.WriteLine("Pirmasis skaičius nėra 1, 2 arba 3.");
                    break;
            }

            //zodzio tikrinimas naudojant switch

            Console.WriteLine("Įveskite gyvūno rūšį:");
            string gyvunas = Console.ReadLine();

            switch (gyvunas.ToLower())
            {
                case "šuo":
                    Console.WriteLine("Įvestas gyvūnas yra šuo.");
                    break;
                case "katė":
                    Console.WriteLine("Įvestas gyvūnas yra katė.");
                    break;
                case "žiurkėnas":
                    Console.WriteLine("Įvestas gyvūnas yra žiurkėnas.");
                    break;
                default:
                    Console.WriteLine("Įvestas gyvūnas nėra šuo, katė ar žiurkėnas.");
                    break;
            }
        }
    }
}

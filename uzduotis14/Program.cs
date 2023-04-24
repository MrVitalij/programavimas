using System;

namespace uzduotis14
{
    internal class Program
    {
        static void Main(string[] args)
        
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //pasirinkimas

            Console.WriteLine("1 - stacionarus kompiuteris");
            Console.WriteLine("2 - nešiojamas kompiuteris");
            Console.WriteLine("3 - planšetė");

            Console.Write("Įveskite pasirinkimo numerį: ");
            int pasirinkimas = Convert.ToInt32(Console.ReadLine());

            switch (pasirinkimas)
            {
                case 1:
                    Console.WriteLine("Stacionariu kompiuteriu galite naudotis tik namuose arba darbo vietoje");
                    break;
                case 2:
                    Console.WriteLine("Nešiojamuoju kompiuteriu galite naudotis visur");
                    break;
                case 3:
                    Console.WriteLine("Planšete galite naudotis visur");
                    break;
                default:
                    Console.WriteLine("Tokio pasirinkimo nėra");
                    break;
            }
        }
    }
}

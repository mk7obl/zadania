using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 
             * static void Main(string[] args)
{
 Console.WriteLine("Wpisz nr dnia tygodnia");
 string numer = Console.ReadLine();
 if (numer == "1")
 Console.WriteLine("Poniedziałek");
 else if (numer == "2")
 Console.WriteLine("Wtorek");
 else if (numer == "3")
 Console.WriteLine("Środa");
 else if (numer == "4")
 Console.WriteLine("Czwartek");
 else if (numer == "5")
 Console.WriteLine("Piątek");
 else if (numer == "6")
 Console.WriteLine("Sobota");
 else if (numer == "7")
 Console.WriteLine("Niedziela");
 else
 Console.WriteLine("Nie ma takiego dnia tygodnia");
 Console.ReadKey();
             */
            int numer;
            Console.WriteLine("Wpisz nr dnia tygodnia");
            numer = int.Parse(Console.ReadLine());

            switch (numer)
            {
                case 1:
                    Console.WriteLine("Poniedziałek");
                    break;
                case 2:
                    Console.WriteLine("Wtorek");
                    break;
                case 3:
                    Console.WriteLine("Środa");
                    break;
                case 4:
                    Console.WriteLine("Czwartek");
                    break;
                case 5:
                    Console.WriteLine("Piątek");
                    break;
                case 6:
                    Console.WriteLine("Sobota");
                    break;
                case 7:
                    Console.WriteLine("Niedziela");
                    break;
                default:
                    Console.WriteLine("Niepoprawne dane");
                    break;

                
            }
            Console.ReadKey();
        }
    }
}

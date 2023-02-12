using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie43
{
    class Program
    {
        static void Main(string[] args)
        {

            int n, max, min, dodatnie;
            double srednia;


            Console.WriteLine("Podaj liczbę elementow tablicy:");
                n = int.Parse(Console.ReadLine());

            int[] tab = new int[n];

            Console.WriteLine("Podaj elementy tablicy");

            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = int.Parse(Console.ReadLine());
            }

            max = tab.Max();

            Console.WriteLine("Maksimum:");
            Console.WriteLine(max);

            Console.WriteLine("Indeks maksimum:");
            Console.WriteLine(Array.IndexOf(tab, max));

            min = tab.Min();

            Console.WriteLine("Minimum:");
            Console.WriteLine(min);

            Console.WriteLine("Indeks minimum:");
            Console.WriteLine(Array.IndexOf(tab, min));


            srednia = tab.Average();
            Console.WriteLine("Srednia:");
            Console.WriteLine(srednia);

            dodatnie = 0;

            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] > 0)
                    dodatnie++;
            }

            Console.WriteLine("Liczba dodatnich elementów tablicy to {0}", dodatnie);
            Console.ReadKey();


        }
    }
}

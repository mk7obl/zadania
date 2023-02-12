using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad41
{
    class Program
    {
        static void Main(string[] args)
        {
            int rozmiar, i;
            Console.WriteLine("Podaj rozmiar tablicy");

            rozmiar = int.Parse(Console.ReadLine());

            int[] tab = new int[rozmiar];

            Console.WriteLine("Podaj elementy tablicy");
            for (i = 0; i < tab.Length; i++ )
            {
                tab[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Elementy tablicy to:");
            for (i=0; i < tab.Length; i++)
            {
                Console.WriteLine(tab[i]);
            }
            Console.ReadKey();
        }
        
    }
}

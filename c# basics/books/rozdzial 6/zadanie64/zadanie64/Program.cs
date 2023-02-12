using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie64
{
    class Licznik
    {
        public int stan1 { get; set; }
        public int stan2 { get; set; }
        public Licznik(int a, int b)
        {
            stan1 = a;
            stan2 = b;
        }

        private static int Zuzycie(int a, int b)
        {
            return b - a;
        }

        public void Wypisz()
        {
            Console.WriteLine("Stan poczatkowy licznika {0} \nStan koncowy Licznika {1}", stan1, stan2);
            Console.WriteLine("Zużycie energii: {0} kWh", Zuzycie(stan1,stan2));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            Licznik li = new Licznik(a,b);
            li.Wypisz();

            Console.ReadKey();
        }
    }
}

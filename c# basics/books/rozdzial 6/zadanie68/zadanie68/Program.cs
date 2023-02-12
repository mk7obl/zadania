using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie68
{
    class Prostopadloscian
    {
        public int dl, sz, h;
        public Prostopadloscian(int a, int b, int c)
        {
            dl = a;
            sz = b;
            h = c;
        }

        public void Prezentuj()
        {
            Console.WriteLine("Prostopadloscian o wymiarach l x b x h: {0}x{1}x{2}", dl, sz, h);
        }

        public static int Objetosc(int l, int b, int h)
        {
            return l * b * h;
        }

        public static void Porownaj(Prostopadloscian a, Prostopadloscian b)
        {
            Console.WriteLine("Objetosc pierwszego prostopadloscianu {0}, objetosc drugiego {1}", Objetosc(a.dl, a.sz, a.h).ToString(), Objetosc(b.dl, b.sz, b.h));
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Prostopadloscian maly = new Prostopadloscian(10, 10, 10);
            Prostopadloscian duzy = new Prostopadloscian(20, 20, 20);

            maly.Prezentuj();
            duzy.Prezentuj();

            Prostopadloscian.Porownaj(maly,duzy);

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie610
{
    struct KandydatNaStudia
    {
        string nazwisko;
        int punktyMatematyka, punktyInformatyka, punktyJO;

        public KandydatNaStudia(string naz, int pktM, int pktI, int pktJO)
        {
            punktyMatematyka = pktM;
            punktyInformatyka = pktI;
            punktyJO = pktJO;
            nazwisko = naz;
        }
        private static double Wskaznik(int a, int b, int c)
        {
            return a * 0.6 + b * 0.5 + c * 0.2;
        }

        public void Prezentuj()
        {
            Console.WriteLine("Kandydat {0}, wskaznik rekrutacji {1}",nazwisko,Wskaznik(punktyMatematyka, punktyInformatyka, punktyJO));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, n;  //matma, informatyka, JO, liczba kandydatow
            string naz;      //nazwisko kandydata

            n = int.Parse(Console.ReadLine());

            KandydatNaStudia[] tab = new KandydatNaStudia[n];

            for (int i=0;i<tab.Length;i++)
            {
                Console.WriteLine("Podaj nazwisko kandydata:");
                naz = Console.ReadLine();

                Console.WriteLine("Podaj wynik z matematyki:");
                a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Podaj wynik z informatyki:");
                b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Podaj wynik z języka obcego:");
                c = Convert.ToInt32(Console.ReadLine());

                tab[i] = new KandydatNaStudia(naz, a, b, c);
            }
            
            foreach (KandydatNaStudia k in tab)
            {
                k.Prezentuj();
            }

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie65
{
    class Punkt
    {
        private double wspX { get; set; }
        private double wspY { get; set; }

        public Punkt(double x, double y)
        {
            wspX = x;
            wspY = y;
        }

        public void Przesun(double c, double d)
        {
            wspX += c;
            wspY += d;
        }
        
        public static void CzyProsta(Punkt[] tab)
        {
            double[] wspkieru = new double[tab.Length];
            int blad = 0;

            for (int i=0;i<tab.Length;i++)
            {
                wspkieru[i] = (tab[i].wspY / tab[i].wspX);
                Console.WriteLine(wspkieru[i]);
            }
            
            for (int j=0;j<wspkieru.Length;j++)
            {
                for (int k = 0; k < wspkieru.Length; k++)
                {
                    if (wspkieru[j] != wspkieru[k])
                        blad++;

                    if (blad > 1)
                        break;
                }
            }

            if (blad == 0)
                Console.WriteLine("Punkty leza na jednej prostej");
            else
                Console.WriteLine("Punkty nie leza na jednej prostej");

        }
        public void Wyswietl()
        {
            Console.WriteLine("Wspolrzedne wektora to: [{0}, {1}]", wspX, wspY);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            double c, d;
            int n;

            Console.WriteLine("Podaj liczbe wektorow: [X,Y]");

            n = int.Parse(Console.ReadLine());
            Punkt[] tab = new Punkt[n];

            Console.WriteLine("Podaj wspolrzedne wektorow.");

            for (int i=0; i<tab.Length;i++)
            {
                a = double.Parse(Console.ReadLine());
                b = double.Parse(Console.ReadLine());
                tab[i] = new Punkt(a, b);
                tab[i].Wyswietl();
            }
            
           /* Console.WriteLine("Podaj wspolrzedne o jakie chcesz przesunac wektor:");
            c = double.Parse(Console.ReadLine());
            d = double.Parse(Console.ReadLine());
           */
            Punkt.CzyProsta(tab);
            Console.ReadKey();
        }
    }
}

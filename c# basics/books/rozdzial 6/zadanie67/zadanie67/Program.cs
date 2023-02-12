using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie67
{
    class Punkt
    {
        private int wspX;
        private int wspY;
        public Punkt(int a, int b)
        {
            wspX = a;
            wspY = b;
        }

       /* public static void Punkty()
        {
            Punkt[] tab = new Punkt[2];

            int a, b;

            for (int i=0; i<tab.Length;i++)
            {
                Console.WriteLine("Podaj wspolrzedne punktu:");
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                tab[i] = new Punkt(a, b);
            }
        }
*/
        public static void Odcinek(Punkt[] tab)
        {
            int dlodc;//pierwiastek sumy

            dlodc = Convert.ToInt32(Math.Sqrt(Math.Pow((tab[1].wspX - tab[0].wspX), 2) + Math.Pow((tab[1].wspY - tab[0].wspY), 2)));
            
            Console.WriteLine("Dlugosc odcinka wynosi {0}",dlodc);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Punkt[] tab = new Punkt[2];

            int a, b;

            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine("Podaj wspolrzedne punktu:");
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                tab[i] = new Punkt(a, b);
            }

            
            Punkt.Odcinek(tab);

            Console.ReadKey();


        }
    }
}

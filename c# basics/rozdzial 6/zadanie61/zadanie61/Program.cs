using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie61
{
    public class Prostokat
    {

        private readonly int dl;//{ get; set; }
        private readonly int sz; //{ get; set; }

        public Prostokat(int a, int b)
        {
            dl = a;
            sz = b;
        }

        private int Powierzchnia(int dl, int sz)
        {
            return dl * sz;
        }

        private int Obwod(int dl, int sz)
        {
            return 2 * dl + 2 * sz;
        }

        public void Prezentuj()
        {
            Console.WriteLine("Pole powierzchni prostokata:{0} Obwod prostokata:{1}", Powierzchnia(dl, sz), Obwod(dl, sz));
        }

    }

    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Podaj ilosc prostokatow:");

            int n;
            n = int.Parse(Console.ReadLine());
            int[] tab = new int[2 * n];


            Console.WriteLine("Podaj długość i szerokość pierwszego prostokąta:");

            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = Convert.ToInt32(Console.ReadLine());

                if ((i + 1) % 2 == 0 && (i != 0) && (i != (2 * n) - 1))
                {
                    Console.WriteLine("Podaj długość i szerokość kolejnego prostokąta:");
                }

            }

            for (int i = 0; i < tab.Length; i++)
            {
                int j;
                j = i + 1;

                if (j < tab.Length)
                {
                    Prostokat p = new Prostokat(tab[i], tab[j]);
                    if (i == 0 || i % 2 == 0)
                        p.Prezentuj();
                }

            }
        }

    }
}

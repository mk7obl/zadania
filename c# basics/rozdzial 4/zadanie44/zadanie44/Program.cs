using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie44
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int [] tab = new int[100];
            int j, dzielniki;

            for (int i = 0; i < 100; i++)
            {
                tab[i] = rand.Next(1, 1000);
                j = 0;
                dzielniki = 0;
                for (j = 1; j < tab[i]; j++)
                {
                    if (tab[i]%j == 0)
                        dzielniki++;
                }

                if (dzielniki<3 && tab[i] !=0)
                {
                    Console.WriteLine(tab[i]);
                }

                
            }

            Console.ReadKey();

        }
    }
}

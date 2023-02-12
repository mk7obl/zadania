using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie45
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Random rand = new Random();
            n = int.Parse(Console.ReadLine());

            int[] tab1 = new int[n];
            int[] tab2 = new int[n];

            for (int i = 0; i < n; i++)
            {
                tab1[i] = rand.Next(1, 100);
                Console.WriteLine(tab1[i]);
            }

            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");

            for (int j = 0; j < tab1.Length; j++)
            {
                if (j == 0)
                {
                    tab2[0] = tab1[n - 1];
                    Console.WriteLine(tab2[0]);
                }
                else if (j > 0)
                {
                    tab2[j] = tab1[j - 1];

                    Console.WriteLine(tab2[j]);
                }
            }


            Console.ReadKey();
        }
    }
}

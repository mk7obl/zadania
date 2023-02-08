using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie47
{
    class Program
    {
        static void Main()
        {

            int[,] tab1 = new int[2, 3];
            int[,] tab2 = new int[2, 3];
            int[,] tab3 = new int[2, 3];

            Random rand = new Random();

            int i, j;

            for (i=0; i < tab1.GetLength(0); i++)
            {
                for (j=0; j < tab1.GetLength(1); j++)
                {
                    tab1[i, j] = rand.Next(1, 10);
                    Console.Write("{0,1} ", tab1[i,j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (i = 0; i < tab2.GetLength(0); i++)
            {
                for (j = 0; j < tab2.GetLength(1); j++)
                {
                    tab2[i, j] = rand.Next(1, 10);
                    Console.Write("{0,1} ", tab2[i,j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (i = 0; i < tab3.GetLength(0); i++)
            {
                for (j = 0; j < tab3.GetLength(1); j++)
                {
                    tab3[i, j] = (tab1[i, j] + tab2[i, j]);
                    Console.Write("{0,1} ", tab3[i, j]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();

   


        }
    }
}

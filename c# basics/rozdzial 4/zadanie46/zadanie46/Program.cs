using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie46
{
    class Program
    {
        static void Main()
        {
            int i, j, suma;

            int[,] tab = new int[5,5];
            Random rand = new Random();

            suma = 0;

            for (i = 0; i < tab.GetLength(0); i++)
            {
                for (j = 0; j < tab.GetLength(1); j++)
                {
                    tab[i, j] = rand.Next(1, 10);
                    Console.Write(tab[i,j]);
                    if (j == i)
                    {
                        suma += tab[i,j];
                    }
                }
                Console.WriteLine();
               
            }

            Console.WriteLine(suma);
            Console.ReadKey();
            
        }
    }
}

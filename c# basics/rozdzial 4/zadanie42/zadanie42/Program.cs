using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie42
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab1 = new int[10];
            int[] tab2 = new int[10];
            int rozmiar=0;
            for (int i = 0; i < tab1.Length; i++)
            {
                tab1[i] = int.Parse(Console.ReadLine());
                if (tab1[i]>0)
                {
                    ++rozmiar;
                    tab2[i] = tab1[i];
                }
                
            }
            for (int i=0; i<tab2.Length;i++)
            {
                if (tab2[i]>0)
                Console.WriteLine(tab2[i]);
            }
            Console.ReadKey();


        }
    }
}

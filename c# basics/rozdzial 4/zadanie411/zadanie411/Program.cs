using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie411
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] tab = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'r', 's', 't', 'u', 'w', 'y', 'z' };
            string slowo;
            int i, suma;
           

            slowo = Console.ReadLine();

           // for (int j=0; j<tab.Length;j++) - alternatywna wersja
           foreach (char x in tab)
            {
                suma = 0;
                for (i=0; i<slowo.Length;i++)
                {
                    if (slowo[i]==x)
                    {
                        suma++;
                    }    
                }
                if (suma!=0)
                Console.WriteLine("{0} - {1}", x, suma);


            }
            Console.ReadKey();

        }
    }
}

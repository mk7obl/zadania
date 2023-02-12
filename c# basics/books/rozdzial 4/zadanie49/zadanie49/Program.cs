using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie49
{
    class Program
    {
        static void Main(string[] args)
        {
            string tekst;
            int wyrazy = 0;
            tekst = Console.ReadLine();

            foreach (char x in tekst)
            {
                if (x==' ')
                {
                    wyrazy++;
                }
            }
            Console.WriteLine(wyrazy+1);
            Console.ReadKey();
        }
    }
}

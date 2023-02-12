using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie414
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] id = new string[5];
            int pozycja, fragment;

            for (int i=0; i<id.Length;i++)
            {
                id[i] = Console.ReadLine();
            }    
            
            for (int j=0; j<id.Length;j++)
            {
                pozycja = id[j].IndexOf('-');

                fragment = int.Parse(id[j].Substring(pozycja+1, 4));
                Console.WriteLine("od zakupu {0} minelo {1} lat", id[j], 2022-fragment);
            }
            Console.ReadKey();
        }
    }
}

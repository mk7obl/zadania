﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.d
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Podaj dlugosc boku kwadratu:");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
            
                for (int j = 1; j <= n; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}

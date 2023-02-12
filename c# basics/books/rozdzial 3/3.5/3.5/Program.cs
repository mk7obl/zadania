using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, delta;
            Console.WriteLine("Podaj wspolczynniki rownania kwadratowego ax2 + bx + c");

            Console.WriteLine("a:");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("b:");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("c:");
            c = double.Parse(Console.ReadLine());

            delta = Math.Pow(b, 2) - 4 * a * c;

            if (delta>0)
            {
                Console.WriteLine("Równanie ma dwa pierwiastki");
            }

            else if (delta < 0)
            {
                Console.WriteLine("Równanie nie ma pierwiastkow");
            }

            else
            {
                Console.WriteLine("Rownanie ma jeden pierwiastek dwukrotny");
            }
            Console.ReadKey();
        }
    }
}

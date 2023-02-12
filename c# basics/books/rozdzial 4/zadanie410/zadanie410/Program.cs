using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie410
{
    class Program
    {
        static void Main(string[] args)
        {
            string data;
            int miesiac;
            string[] tabmc = {"styczen", "luty", "marzec", "kwiecien", "maj", "czerwiec", "lipiec", "sierpien", "wrzesien", "pazdziernik", "listopad", "grudzien"};


            Console.WriteLine("Podaj date w formacie DD-MM-RRRR");

            data = Console.ReadLine();

            miesiac = int.Parse(data.Substring(3, 2));

            if (miesiac <= 12)
            {
                Console.WriteLine(tabmc[miesiac - 1]);
            }

            else
                Console.WriteLine("Niepoprawne dane.");

            Console.ReadKey();

        }
    }
}

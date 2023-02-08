using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie412
{
    class Program
    {
        static void Main(string[] args)
        {
            string tekst = "W parę godzin później, gdy noc zbierała się do odejścia,\n" +
                            "Puchatek obudził się nagle z uczuciem dziwnego przygnębienia.\n" +
                            "To uczucie dziwnego przygnębienia miewał już nieraz i wiedział,\n" +
                            "co ono oznacza. Był głodny. Więc poszedł do spiżarni,\n" +
                            "wgramolił się na krzesełko, sięgnął na górną półkę, ale nic nie znalazł.";
            int wiersze, znaki;
            wiersze = 0;
            znaki = 0;
            Console.WriteLine(tekst);

          /*  Alternatywna wersja, najpierw pokazuje ile jest wierszy.
            foreach (char x in tekst)
            {
                if (x == '\n')
                {
                    wiersze++;
                }
            }

          */
            Console.WriteLine(wiersze+1);

            for (int i = 0; i < tekst.Length; i++)
            {
                if (tekst[i] != '\n')
                {
                    znaki++;
                }

                if ((tekst[i] == '\n') || (i == tekst.Length-1 ))
                {
                    wiersze++;
                    Console.WriteLine("\n{0} Wiersz - {1} znakow", wiersze, znaki);
                    znaki = 0;
                }

            }
            Console.WriteLine("\n{0} wierszy", wiersze);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie413
{
    class Program
    {
        static void Main(string[] args)
        {
            string tekst = "Kiedy idzie się po miód z balonikiem, to trzeba się starać, żeby pszczoły nie wiedziały, po co się idzie – odpowiedział Puchatek.";
            string slowo = "";
            int wynik;
            int slowa = 0;
            int numer = 0;

            int i, j, licznosc;

            foreach (char x in tekst)
            {
                if (x == ' ')
                    slowa++;
            }

            string[] slownik = new string[slowa];

            for (i = 0; i < tekst.Length; i++)
            {

                if (tekst[i] != ' ')
                {
                    slowo += tekst[i];

                }

                if (tekst[i] == ' ')
                {

                    slownik[numer] = slowo;

                    numer++;
                    slowo = "";

                }

            }

            int koniec = 0;

            for (j = 0; j < slowa; j++)
            {
                licznosc = 0;
                string[] koncowa = new string[slowa];
                
                for (i = 0; i < slownik.Length; i++)
                {
                    wynik = String.Compare(slownik[j], slownik[i]);

                    
                        if (wynik == 0)
                        {
                            licznosc++;

                        }
                   
                }


                if (licznosc >= 2)
                {

                    
                    Console.WriteLine("{0} {1}", slownik[j], licznosc);
                    koncowa[j] = slownik[j];

                  

                }

                //else if ()

            }

            Console.ReadKey();

        }
    }
}

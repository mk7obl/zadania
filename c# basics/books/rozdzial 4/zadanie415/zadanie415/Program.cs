using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie415
{
    class Program
    {
        static void Main(string[] args)
        {
            //                  0    1    2    3    4    5    6    7    8    9    10   11
            string[] klucz = { "G", "A", "D", "E", "R", "Y", "P", "O", "L", "U", "K", "I" };   //klucz szyfru
            string tekst;

            Console.WriteLine("Podaj słowo:");  
            tekst = Console.ReadLine();     //wprowadzenie slowa

            string[] teksttab = new string[tekst.Length];   //zdefiniowanie tablicy na tekst

            int[] wyniki = new int[klucz.Length];   //tablica na wyniki metody compare, w zaleznosci od dlugosci klucza
            int wynik = 0;
            int wypisanie = 0;


            for (int k = 0; k < tekst.Length; k++)  //wpisywanie tekstu(string) do tablicy na tekst (string[])
            {
                teksttab[k] = tekst[k].ToString();
            }

            Console.WriteLine("Zaszyfrowane slowo to:");

            for (int j = 0; j < teksttab.Length; j++)   //wczytanie j-tego elementu tablicy (j-ta litera slowa wprowadzonego)
            {
                wypisanie = 0;

                for (int i = 0; i < klucz.Length; i++)  //wczytanie i-tego elementu klucza (wczytuje kazdy po kolei)
                {
                    wynik = String.Compare(teksttab[j], klucz[i]);  //porownanie (j-tej) litery tekstu, z (i-tym) elementem tablicy klucza - jezeli tak, wypisze 0
                    wyniki[i] = wynik;

                    if (wynik == 0 && (i % 2 == 0 || i == 0))   //jezeli j-ty element tekstu, pokrywa sie z i-tym elementem klucza, a i jest liczba parzysta lub i==0...
                    {
                        Console.Write(klucz[i + 1]);            //to wypisz element tablicy po prawej stronie i-tego elementu
                        wypisanie++;                            //jezeli litera tekstu ulega zmianie w skutek szyfrowania, zmienna przyjmuje wartosc 1
                        break;
                    }

                    else if ((wynik == 0) && (i % 2 != 0) && (i != 0))  //jezeli j-ty element tekstu, pokrywa sie z i-tym elementem klucza, a i jest liczba nieparzysta, rozna od 0
                    {
                        Console.Write(klucz[i - 1]);    //to wypisz element tablicy po lewej stronie i-tego elementu
                        wypisanie++;                    //jezeli litera tekstu ulega zmianie w skutek szyfrowania, zmienna przyjmuje wartosc 1
                        break;
                    }

                }

                if (wypisanie == 0)     //jezeli litera tekstu nie ulega zmianie w skutek szyfrowania, a co za tym idzie - zmienna wypisanie==0, to:
                {
                    Console.Write(teksttab[j]);     //wypisz j-ta litere tekstu;
                }

            }
            Console.ReadKey();

        }
    }
}

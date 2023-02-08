using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Napisz program, który tworzy klasę Prostokat, zawierającą dwie prywatne dane
składowe: dlugosc, szerokosc, dwie prywatne metody: powierzchnia(), obwod() oraz metodę
publiczną – Prezentuj() (która wyświetla powierzchnię i obwód prostokąta) i konstruktor
inicjalizujący. W metodzie Main() zdefiniuj obiekt i uruchom dla niego metodę Prezentuj(). 

Uzupełnij program z poprzedniego zadania o definicje tablicy obiektów dla
prostokątów. W metodzie Main() wyświetl powierzchnie oraz obwód wszystkich prostokątów
w tablicy używając (wewnątrz pętli foreach) metody publicznej Prezentuj()
*/
namespace zadanie69a
{
    struct Prostokat
    {
        private int dl, sz;

        public Prostokat(int a, int b)
        {
            dl = a;
            sz = b;
        }

        private static int Powierzchnia(int dl, int sz)
        {
            return dl * sz;
        }

        private static int Obwod(int dl, int sz)
        {
            return 2 * dl + 2 * sz; 
        }

        public void Prezentuj()
        {
            Console.WriteLine("Powierzchnia {0}, obwod {1}", Powierzchnia(dl, sz), Obwod(dl, sz));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n, a, b;
            n = Convert.ToInt32(Console.ReadLine());

            Prostokat[] tab = new Prostokat[n];

            for (int i=0; i<tab.Length;i++)
            {
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());

                tab[i] = new Prostokat(a, b);
            }
            
            foreach (Prostokat p in tab)
            {
                p.Prezentuj();
            }
            Console.ReadKey();
        }
    }
}

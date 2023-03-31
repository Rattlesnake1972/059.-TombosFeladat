using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TombosFeladat
{
    class Program
    {
        static void Main(string[] args)
        {
            //tömb deklarálása
            int[] sebessegtomb = new int[10];
            //feltöltés random értékekkel
            Random r = new Random();
            for (int i = 0; i < sebessegtomb.Length; i++)
            {
                sebessegtomb[i] = r.Next(0, 200);
                Console.Write(sebessegtomb[i] + " ");
            }
            Console.WriteLine();
            //összegzés tétele: összegezzük a tömb elemeit!
            int osszeg = 0;
            for (int i = 0; i < sebessegtomb.Length; i++)
            {
                osszeg += sebessegtomb[i];
            }
            Console.WriteLine("A tömb elemeinek összege: " + osszeg);
            //Feltételes összegzés
            int osszegf = 0;
            for (int i = 0; i < sebessegtomb.Length; i++)
            {
                if (sebessegtomb[i] > 100)
                {
                    osszegf += sebessegtomb[i];
                }
            }
            Console.WriteLine("A 100-nál gyorsabb kocsik sebességösszegei: " + osszegf);

            //megszámlálás
            int db = 0;
            for (int i = 0; i < sebessegtomb.Length; i++)
            {
                if (sebessegtomb[i] % 2 == 0)
                {
                    db++;
                }
            }
            Console.WriteLine("A páros számok: " + db);
            //eldontés tétele
            bool vane = false;
            for (int i = 0; i < sebessegtomb.Length; i++)
            {
                if (sebessegtomb[i] > 180)
                {
                    vane = true;
                    //break;
                }
                Console.WriteLine(vane);
            }
            //minimum
            int min = sebessegtomb[0];
            for (int i = 0; i < sebessegtomb.Length; i++)
            {
                if (sebessegtomb[i] < min)
                {
                    min = sebessegtomb[i];
                }
            }
            Console.WriteLine("A tömb elemeinek minimuma: " + min);

            //maximum
            int max = sebessegtomb[0];
            for (int i = 0; i < sebessegtomb.Length; i++)
            {
                if (sebessegtomb[i] > max)
                {
                    max = sebessegtomb[i];
                }
            }
            Console.WriteLine("A tömb elemeinek maximuma: " + max);
            //csere1
            int a = 4;
            int b = 7;
            Console.WriteLine("a: " + a + " b: " + b);
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("a: " + a + " b: " + b);
            Console.ReadLine();
        }
    }
}

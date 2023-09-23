using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uvodnaVjezba02_Matej_Lukas_Marunica_3.D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            double c, d, rez;

            a = 10;
            b = 7;
            c = 12.5;
            d = 16.7;
            rez = (a + b + c + d) / 4;


            Console.WriteLine("Prosječna vrijednost varijabla a, b, c, d iznosi: " + rez);
            Console.ReadKey();
        }
    }
}

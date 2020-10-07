using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Informatik_Hausarbeit
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 10;
            int min = 0;
            int max = 20;
            long ng = 1000000;
            int ni = 0;
            int A = (max - min) * (b - a);
            double x;
            double y;
            Console.WriteLine("Lennart Meyer");

            Console.WriteLine("Bitte geben Sie ihre Matrikelnummer ein: ");
            int mtrklnr = Convert.ToInt32(Console.ReadLine());
            int c = mtrklnr % 10;

            Console.WriteLine("Berechne ...");
            
            for (int i = 0; i < ng; i++)
            {
                x = rnd(a, b);
                y = rnd(min, max);
                if (f(x, c) >= y)
                    ni++;
            
            }

            double Ai = (double)ni / (double)ng * A;
            Console.WriteLine("Ergebnis: "+ Ai);
            Console.ReadLine();

        }
        
        static double f(double x, int c)
        {
            return (0.5 * x + c);
        }

        public static double rnd(double g, double h)
        {
            Random rand = new Random();
            return(g + (rand.NextDouble() * (h - g)));
        }

    }
}
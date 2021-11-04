using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ7._1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToInt32(Console.ReadLine());
            double V, S;
            CoubeReb(a, out V, out S);
            Console.WriteLine("Площадь куба:\t" + S + " кв.см");
            Console.WriteLine("Объём куба:\t" + V + " куб.см");
            Console.ReadKey();

        }
        static double CoubeReb(double a, out double V, out double S)
        {
            V = Math.Pow(a, 3);
            S = Math.Pow(a, 2) * 6;
            return V;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Треугольник №1.Задайте длинну стороны x1 :");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Треугольник №1.Задайте длинну стороны y1 :");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Треугольник №1.Задайте длинну стороны z1 :");
            double z1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Треугольник №2.Задайте длинну стороны x2 :");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Треугольник №2.Задайте длинну стороны y2 :");
            double y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Треугольник №2.Задайте длинну стороны z2 :");
            double z2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Площадь треугольника №1 = {0}, площадь треугольника №2 = {1}", Treug(x1, y1, z1), Treug(x2, y2, z2));
            if (Treug(x1, y1, z1)> Treug(x2, y2, z2))
            {
                Console.WriteLine("Площадь треугольника №1 больше, чем площадь треугольника №2");
            }
            if (Treug(x1, y1, z1) < Treug(x2, y2, z2))
            {
                Console.WriteLine("Площадь треугольника №2 больше, чем площадь треугольника №1");
            }
            if (Treug(x1, y1, z1) == Treug(x2, y2, z2))
            {
                Console.WriteLine("Площадь треугольников равна");
            }
            Console.Read();
        }
        static double Treug(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return S;
        }
        
    }
}

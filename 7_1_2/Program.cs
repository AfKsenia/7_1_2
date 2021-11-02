using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {//вот лучше вместо этого массив;
            Console.WriteLine("Ввведите длину первой стороны первого треугольника");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ввведите длину второй стороны первого треугольника");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ввведите длину третьей стороны первого треугольника");
            double z = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ввведите длину первой стороны второго треугольника");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ввведите длину второй стороны второго треугольника");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ввведите длину третьей стороны второго треугольника");
            double z1 = Convert.ToDouble(Console.ReadLine());
            /*Console.WriteLine("Площадь первого треугольника = {0:F2}", TriSquare(x, y, z));
            Console.WriteLine("Площадь второго треугольника = {0:F2}", TriSquare(x1, y1, z1));*/
            if (TriSquare(x, y, z) > TriSquare(x1, y1, z1))
            {
                Console.WriteLine("Площадь первого треугольника больше и равна {0:F2}", TriSquare(x, y, z));
            }
            else if (TriSquare(x, y, z) < TriSquare(x1, y1, z1))
            {
                Console.WriteLine("Площадь второго треугольника больше и равна {0:F2}", TriSquare(x1, y1, z1));
            }
            else
            {
                Console.WriteLine("Площади треугольников равны, S = {0:F2}", TriSquare(x1, y1, z1));
            }
            Console.ReadKey();
        }
        static double TriSquare(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return S;
        }
    }
}


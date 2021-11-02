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
        {
            Console.WriteLine("Ввведите длину ребра куба");
            double a = Convert.ToDouble(Console.ReadLine());
            Cub(ref a);
            Console.ReadKey();
        }
        static void Cub(ref double b)
        {
            double S = 6 * Math.Pow(b, 3);
            double V = Math.Pow(b, 3);
            Console.WriteLine("Площадь поверхности куба со стороной {0} равна {1:F2}", b, S);
            Console.WriteLine("Объем куба со стороной {0} равна {1:F2}", b, V);

        }
    }
}


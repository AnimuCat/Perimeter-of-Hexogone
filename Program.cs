using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hexagon
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            Hexagon hexagon = new Hexagon();

            Console.WriteLine(hexagon.calculate_perimeter(size));
            Console.WriteLine(hexagon.random_calculate_perimeter());
            Console.ReadKey();
        }
    }
}

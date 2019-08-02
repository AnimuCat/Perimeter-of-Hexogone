using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hexagon
{
    public class Hexagon
    {
        public int calculate_perimeter(int size)
        {
            int Perimeter;
            return Perimeter = size * 6;
        }

        public int random_calculate_perimeter()
        {
            Random randSize = new Random();
            int randSizeInt = randSize.Next(1, 999999);

            return randSizeInt * 6;
        }
    }
}

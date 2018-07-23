using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._87
{
    class Program
    {
        static void Main(string[] args)
        {
            Double.TryParse(Console.ReadLine(), out double x);
            if (x <= 0)
            {
                Console.WriteLine(0);
            }
            else if (x > 0 && x <= 1)
            {
                Console.WriteLine(x);
            }
            else
            {
                Console.WriteLine(Math.Pow(x, 2));
            }
        }
    }
}

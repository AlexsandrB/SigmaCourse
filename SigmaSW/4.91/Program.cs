using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._91
{
    class Program
    {
        static void Main(string[] args)
        {
            Double.TryParse(Console.ReadLine(), out double x);

            if (x < -1)
            {
                Console.WriteLine(0);
            }
            else if (x > 1)
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(x);
            }

            if (x < -1)
            {
                Console.WriteLine(1);
            }
            else if (x > 1)
            {
                Console.WriteLine(-1);
            }
            else
            {
                Console.WriteLine(-x);
            }

            if (x < -1)
            {
                Console.WriteLine(1);
            }
            else if (x > 1)
            {
                Console.WriteLine(1);
            }
            else if (x >= -1 && x <= 0)
            {
                Console.WriteLine(-0.5 * x + 0.5);
            }
            else
            {
                Console.WriteLine(0.5 * x + 0.5);
            }
        }
    }
}

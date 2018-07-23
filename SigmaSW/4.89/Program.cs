using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._89
{
    class Program
    {
        static void Main(string[] args)
        {
            Double.TryParse(Console.ReadLine(), out double x);
            double k;

            if (Math.Sin(x) < 0)
            {
                k = Math.Pow(x, 2);
            }
            else
            {
                k = Math.Abs(x);
            }

            if (k < x)
            {
                Console.WriteLine(k * x);
            }
            else
            {
                Console.WriteLine(k + x);
            }
        }
    }
}

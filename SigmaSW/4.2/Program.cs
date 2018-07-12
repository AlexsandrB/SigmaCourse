using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = Double.Parse(Console.ReadLine());

            if (x > 0)
            {
                Console.WriteLine(Math.Sin(x * x));
            }
            else
            {
                Console.WriteLine(1 + 2 * Math.Pow(Math.Sin(x), 2));
            }
            Console.ReadKey();
        }
    }
}

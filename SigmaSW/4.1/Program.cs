using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = Double.Parse(Console.ReadLine());
            
            if (x > 0)
            {
                Console.WriteLine(Math.Pow(Math.Sin(x), 2));
            }
            else
            {
                Console.WriteLine(1 + 2 * Math.Sin(x*x));
            }
            Console.ReadKey();
        }
    }
}

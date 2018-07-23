using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._85
{
    class Program
    {
        static void Main(string[] args)
        {
            Double.TryParse(Console.ReadLine(), out double x);
            if (x < -1)
            {
                Console.WriteLine(1);
            }
            else if (x > -1)
            {
                Console.WriteLine(x);
            }
            else
            {
                Console.WriteLine(-1);
            }
        }
    }
}


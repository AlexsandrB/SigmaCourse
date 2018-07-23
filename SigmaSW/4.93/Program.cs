using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._93
{
    class Program
    {
        static void Main(string[] args)
        {
            Double.TryParse(Console.ReadLine(), out double x);
            if (x < 2.5)
            {
                Console.WriteLine(3);
            }
            else if (x > 5)
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(2);
            }
        }
    }
}

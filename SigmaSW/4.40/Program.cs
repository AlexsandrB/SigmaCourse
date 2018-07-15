using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._40
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = Convert.ToDouble(Console.ReadLine());

            if (x >= -2.4 && x <= 5.7)
            {
                Console.WriteLine(x * x);
            }
            else
            {
                Console.WriteLine(4);
            }
            Console.ReadKey();

        }
    }
}

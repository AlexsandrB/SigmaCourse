using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._5
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = Convert.ToDouble(Console.ReadLine());

            if (x < 2)
            {
                Console.WriteLine(x);
            }
            else
            {
                Console.WriteLine(2);
            }

            if (x < 3)
            {
                Console.WriteLine(-x);
            }
            else
            {
                Console.WriteLine(-3);
            }
            Console.ReadKey();
        }
    }
}

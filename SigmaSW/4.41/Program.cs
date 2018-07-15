using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._41
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = Convert.ToDouble(Console.ReadLine());

            if (x >= -0.2 && x <= 0.9)
            {
                Console.WriteLine(Math.Sin(x));
            }
            else
            {
                Console.WriteLine(1);
            }

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._38
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = Double.Parse(Console.ReadLine());
            double y = Double.Parse(Console.ReadLine());

            if (x > 3 && y > 2)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

            if (x < -4 && y < -2)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }


            Console.ReadKey();
        }
    }
}

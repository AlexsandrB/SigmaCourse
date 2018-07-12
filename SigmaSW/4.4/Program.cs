using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());

            if (y > 3)
            {
                Console.WriteLine("I");
            }
            else
            {
                Console.WriteLine("II");
            }
            Console.ReadKey();
        }
    }
}

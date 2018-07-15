using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._39
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = Double.Parse(Console.ReadLine());

            if (x < -1)
            {
                Console.WriteLine("III");
            }
            else if (x > -1 && x < 5)
            {
                Console.WriteLine("II");
            }
            else
            {
                Console.WriteLine("I");
            }


            Console.ReadKey();
        }
    }
}

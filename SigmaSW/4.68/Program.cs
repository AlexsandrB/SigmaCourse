using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._68
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("set speed and angle");
            double v0 = Convert.ToDouble(Console.ReadLine());
            double alpha = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("set target height and bottom margin and lenght");
            double height = Convert.ToDouble(Console.ReadLine());
            double bmargin = Convert.ToDouble(Console.ReadLine());
            double lenght = Convert.ToDouble(Console.ReadLine());

            double t = lenght / (v0 * Math.Cos(alpha));


            double shootHeight = v0 * t * Math.Sin(alpha) - (9.8 * t * t) / 2; 

            if (shootHeight < (height + bmargin) && shootHeight > bmargin)
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

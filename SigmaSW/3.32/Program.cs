using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._32
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());

            if (x <= 3 && y >= 1)
                Console.WriteLine("true");
            else
                Console.WriteLine("false");

            if (y <= 1.5 && y >= -2)
                Console.WriteLine("true");
            else
                Console.WriteLine("false");

            if (y <= 4 && y >= 0 && x >= 1 && x <= 2)
                Console.WriteLine("true");
            else
                Console.WriteLine("false");

            if (y <= 4 && y >= 2 && x >= 1)
                Console.WriteLine("true");
            else
                Console.WriteLine("false");

            if ((y >= 0 && x >= 2) || (y <= -1 && x >= 1))
                Console.WriteLine("true");
            else
                Console.WriteLine("false");

            if ((y >= 1 && x >= 2) || (x >= 2 && y <= -1.5))
                Console.WriteLine("true");
            else
                Console.WriteLine("false");

            if (x >= 1 && x <= 3 && y <= -1 && y >= -2)
                Console.WriteLine("true");
            else
                Console.WriteLine("false");

            if ((x <= 2 && y <= 1.5 && y >= 0.5) || (x >= 2))
                Console.WriteLine("true");
            else
                Console.WriteLine("false");
        }
    }
}

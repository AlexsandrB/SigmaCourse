using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._29
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a");
            Int32.TryParse(Console.ReadLine(), out int a);
            Console.WriteLine("b");
            Int32.TryParse(Console.ReadLine(), out int b);


            Console.WriteLine(DiffAverage(1, 1000));
            Console.WriteLine(DiffAverage(100, b));
            Console.WriteLine(DiffAverage(a, 200));
            Console.WriteLine(DiffAverage(a, b));
        }

        private static double DiffAverage(int a, int b)
        {
            double sum = 0.0;
            for (int i = a; i <= b; i++)
            {
                sum += i;
            }
            return sum / (b - a + 1);
        }
    }
}

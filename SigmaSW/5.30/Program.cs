using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._30
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a");
            Int32.TryParse(Console.ReadLine(), out int a);
            Console.WriteLine("b");
            Int32.TryParse(Console.ReadLine(), out int b);
            Console.WriteLine("n");
            Int32.TryParse(Console.ReadLine(), out int n);


            Console.WriteLine(PowendTo3Sum(20, 40));
            Console.WriteLine(PowendTo3Sum(a, 50));
            Console.WriteLine(PowendTo3Sum(1, n));
            Console.WriteLine(PowendTo3Sum(a, b));
        }

        private static double PowendTo3Sum(int a, int b)
        {
            double sum = 0.0;
            for (int i = a; i <= b; i++)
            {
                sum += Math.Pow(i, 3);
            }
            return sum;
        }
    }
}

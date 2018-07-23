using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a");
            Int32.TryParse(Console.ReadLine(), out int a);
            Console.WriteLine("b");
            Int32.TryParse(Console.ReadLine(), out int b);


            Console.WriteLine(DiffSum(100, 500));
            Console.WriteLine(DiffSum(a, 500));
            Console.WriteLine(DiffSum(-10, b));
            Console.WriteLine(DiffSum(a, b));
        }

        private static long DiffSum(int a, int b)
        {
            long sum = 0;
            for (int i = a; i <= b; i++)
            {
                sum += i;
            }
            return sum;
        }
    }
}

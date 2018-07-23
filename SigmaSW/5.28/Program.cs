using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a");
            Int32.TryParse(Console.ReadLine(), out int a);
            Console.WriteLine("b");
            Int32.TryParse(Console.ReadLine(), out int b);


            Console.WriteLine(DiffMultiplication(8, 15));
            Console.WriteLine(DiffMultiplication(a, 20));
            Console.WriteLine(DiffMultiplication(1, b));
            Console.WriteLine(DiffMultiplication(a, b));
        }

        private static long DiffMultiplication(int a, int b)
        {
            long mult = 1;
            for (int i = a; i <= b; i++)
            {
                mult *= i;
            }
            return mult;
        }
    }
}

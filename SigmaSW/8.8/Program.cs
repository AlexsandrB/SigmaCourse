using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._8
{
    class Program
    {
        private static string addStr(int dig)
        {
            if (dig > 9)
            {
                return "   ";
            }
            else
            {
                return "    ";
            }
        }

        static void Main(string[] args)
        {
            int i, j;

            for (i = 1; i <= 9; i++)
            {
                for (int q = 1; q <= 9; q++)
                {
                    Console.Write($"{q} x {i} = {q * i}{addStr(q * i)}");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}

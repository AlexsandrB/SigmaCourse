using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int q = 0; q <= i; q++)
                {
                    Console.Write($" {i + 1}");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n\n");

            for (int i = 4; i < 9; i++)
            {
                for (int q = 0; q <= 8 - i; q++)
                {
                    Console.Write($" {i + 1}");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n\n");

            for (int i = 0; i < 5; i++)
            {
                for (int q = 0; q <= i; q++)
                {
                    Console.Write($" {(i + 1) * 10}");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n\n");

            for (int i = 0; i < 5; i++)
            {
                for (int q = 0; q <= 4 - i; q++)
                {
                    Console.Write($" {(i + 1) * 5}");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}

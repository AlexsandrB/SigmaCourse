using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._15
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32.TryParse(Console.ReadLine(), out int n);
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine($"{i}*{n}={i * n}");
            }
        }
    }
}

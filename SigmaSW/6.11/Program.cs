using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._11
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32.TryParse(Console.ReadLine(), out int a);

            for (int i = 2; (1 + 1 / i) >= a; i++)
            {
                Console.Write((1 + 1 / (double)i) + " ");
            }
        }
    }
}

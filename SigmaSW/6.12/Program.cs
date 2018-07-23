using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._12
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32.TryParse(Console.ReadLine(), out int a);

            int i;
            for (i = 2; (1 + 1 / i) >= a; i++) { }

            Console.WriteLine((1 + 1 / (double)i));
        }
    }
}

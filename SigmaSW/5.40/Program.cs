using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._40
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32.TryParse(Console.ReadLine(), out int n);

            Console.WriteLine(Console.ReadLine().Split(' ').Select(c => { Double.TryParse(c, out double a); return a; }).ToList().Sum());
        }
    }
}

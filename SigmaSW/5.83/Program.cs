using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._83
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32.TryParse(Console.ReadLine(), out int n);
            
            Int32.TryParse(Console.ReadLine(), out int a);

            long res = a;
            for (int i = 2; i <= n; i++)
            {
                res *= a;
            }

            Console.WriteLine(res);
        }
    }
}

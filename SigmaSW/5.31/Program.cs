using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._31
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            Int32.TryParse(Console.ReadLine(), out int n);

            for (int i = 0; i <= n; i++)
            {
                sum += Math.Pow(n + i, 2);
            }

            Console.WriteLine(sum);
        }
    }
}

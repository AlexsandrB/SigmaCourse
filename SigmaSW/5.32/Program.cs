using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._32
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            Int32.TryParse(Console.ReadLine(), out int n);

            for (int i = 1; i <= n; i++)
            {
                sum += (1 / i);
            }

            Console.WriteLine(sum);
        }
    }
}

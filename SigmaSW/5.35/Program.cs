using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._35
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            Int32.TryParse(Console.ReadLine(), out int n);

            for (int i = 1; i <= n; i += 2)
            {
                sum += (1 / i);
            }

            for (int i = 2; i <= n; i += 2)
            {
                sum += (1 / i);
            }

            Console.WriteLine(sum);
        }
    }
}

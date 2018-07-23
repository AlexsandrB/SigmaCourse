using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._36
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            Int32.TryParse(Console.ReadLine(), out int x);

            for (int i = 1; i <= 11; i++)
            {
                sum += (Math.Pow(x, i) / i);
            }

            Console.WriteLine(sum);
        }
    }
}

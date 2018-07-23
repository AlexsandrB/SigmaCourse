using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._37
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 1;
            Int32.TryParse(Console.ReadLine(), out int x);

            for (int i = 1; i <= 10; i++)
            {
                sum += (Math.Pow(-1, i) * ((i + 1) / (i + 2)) * Math.Pow(x, i));
            }

            Console.WriteLine(sum);
        }
    }
}

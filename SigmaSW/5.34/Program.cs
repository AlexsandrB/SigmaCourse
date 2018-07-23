using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._34
{
    class Program
    {
        static void Main(string[] args)
        {
            double prev = 1, sum = 0;
            for (int i = 0; i <= 9; i++)
            {
                sum += (1 / prev);
                prev /= 3;
            }

            Console.WriteLine(sum);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._33
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;

            for (int i = 2; i <= 10; i++)
            {
                sum += (i / (i + 1));
            }

            Console.WriteLine(sum);
        }
    }
}

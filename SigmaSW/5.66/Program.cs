using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._66
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32.TryParse(Console.ReadLine(), out int n);

            double[] array = new double[n + 1];
            array[0] = 1;

            for (int i = 1; i < n + 1; i++)
            {
                array[i] = i * array[i - 1] + 1 / i;
            }
            Console.WriteLine(array[n]);
        }
    }
}

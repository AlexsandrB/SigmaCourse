using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._36
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int k = 6; k <= 100000; k++)
            {
                for (int i = 1; i <= k / 2; i++)
                {
                    if (k % i == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}

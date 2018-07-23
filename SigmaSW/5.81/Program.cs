using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._81
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32.TryParse(Console.ReadLine(), out int x);
            
            Int32.TryParse(Console.ReadLine(), out int y);

            long sum = 0;
            for (int i = 0; i < y; i++)
            {
                sum += x;
            }
            Console.WriteLine(sum);
            sum = 0;
            for (int i = 0; i < x; i++)
            {
                sum += y;
            }
            Console.WriteLine(sum);
        }
    }
}

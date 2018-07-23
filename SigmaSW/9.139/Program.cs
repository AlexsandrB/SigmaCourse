using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._139
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().ToList();
            s.ForEach(c =>
            {
                if (c >= '0' && c <= '9')
                {
                    Console.WriteLine(c);
                }
            });
        }
    }
}

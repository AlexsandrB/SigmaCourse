using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._62
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().ToList();
            Console.WriteLine(s.Count(c => c == 'а') * 100 / (double)s.Count + "%");
        }
    }
}

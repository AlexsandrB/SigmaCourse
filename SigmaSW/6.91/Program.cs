using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._91
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = Console.ReadLine().Select(c => { Int32.TryParse(c.ToString(), out int a); return a; }).ToList();
            Console.WriteLine(number.Count);
            Console.WriteLine(number.Sum());
            long mult = 1;
            number.ForEach(c => mult *= c);
            Console.WriteLine(mult);
            Console.WriteLine(number.Sum() / (double)number.Count());
            mult = 0;
            number.ForEach(c => mult += c * c);
            Console.WriteLine(mult);
        }
    }
}

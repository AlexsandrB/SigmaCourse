using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._142
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().Replace(" ", "");
            var numbers = s.Select(c => { Int32.TryParse(c.ToString(), out int a); return a; }).Where(c => c >= '0' && c <= '9').ToList();
            var max = numbers.Max();
            Console.WriteLine($"Result: {s.IndexOf(max.ToString())}");
        }
    }
}

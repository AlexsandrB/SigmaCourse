using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._141
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().Select(c => { Int32.TryParse(c.ToString(), out int a); return a; }).Where(c => c >= '0' && c <= '9').ToList();
            Console.WriteLine(s.Sum());
            Console.WriteLine(s.Max());
        }
    }
}

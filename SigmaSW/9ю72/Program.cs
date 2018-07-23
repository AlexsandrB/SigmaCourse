using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9ю72
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().Split(' ').ToList();
            Console.WriteLine(s.Select(c => c != "").Count() > 3);
        }
    }
}

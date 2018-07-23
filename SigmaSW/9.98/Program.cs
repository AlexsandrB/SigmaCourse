using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._98
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter sentence");
            var s = Console.ReadLine();
            Console.WriteLine("Enter s1");
            var s1 = Console.ReadLine();
            Console.WriteLine("Enter s2");
            var s2 = Console.ReadLine();

            Console.WriteLine(s.Replace(s1, s2));
        }
    }
}

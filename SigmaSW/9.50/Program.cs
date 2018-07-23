using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._50
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First");
            var first = Console.ReadLine();
            Console.WriteLine("Second");
            var second = Console.ReadLine();
            Console.WriteLine("Count");
            Int32.TryParse(Console.ReadLine(), out int count);

            Console.WriteLine(first + second.Remove(0, count));
        }
    }
}

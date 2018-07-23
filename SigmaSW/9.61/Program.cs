using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._61
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Symbol");
            var symbol = Console.ReadLine().ToCharArray();
            Console.WriteLine(Console.ReadLine().Count(c => c == symbol[0]));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._52
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Symbol");
            var symbol = Console.ReadLine().ToCharArray();
            Console.WriteLine("Sentense");
            var s = Console.ReadLine();
            s.ToList().ForEach(c => { if (c == symbol[0]) { Console.WriteLine(c); } });
        }
    }
}

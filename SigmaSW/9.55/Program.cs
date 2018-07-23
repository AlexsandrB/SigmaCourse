using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._55
{
    class Program
    {
        static void Main(string[] args)
        {
            var symbols = Console.ReadLine();
            symbols = symbols.Remove(symbols.IndexOf(' '), 1);
            var symbolList = symbols.ToList();
            Console.WriteLine("Sentense");
            Console.ReadLine().ToList().ForEach(c =>
            {
                if (c == symbols[0] || c == symbols[1])
                {
                    Console.WriteLine(c);
                }
            });
        }
    }
}

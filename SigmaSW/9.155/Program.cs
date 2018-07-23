using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._155
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().ToList();
            s.ForEach(c =>
            {
                if (s.Count(x => x == c) == 2)
                {
                    Console.WriteLine(c);
                    return;
                }
            });
        }
    }
}

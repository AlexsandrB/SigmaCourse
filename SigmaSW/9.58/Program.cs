using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._58
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().ToList();
            for (int i = 0; i < s.Count - 1; i += 4)
            {
                Console.WriteLine(s[i] + "\n" + s[i + 1]);
            }
        }
    }
}

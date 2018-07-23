using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._43
{
    class Program
    {
        static void Main(string[] args)
        {
            var s1 = Console.ReadLine().ToList();
            for (int i = 1; i < s1.Count; i += 2)
            {
                Console.Write(s1[i]);
            }
        }
    }
}

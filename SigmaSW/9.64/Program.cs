using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._64
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().ToList();
            long count = 0;
            for (int i = 0; i < s.Count - 1; i++)
            {
                if (s[i] == s[i + 1])
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}

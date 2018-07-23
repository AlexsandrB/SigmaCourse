using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._74
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().ToList();
            for (int i = 0; i < s.Count - 5; i += 5)
            {
                if (s[i] == s[i + 1] && s[i] == s[i + 2] && s[i] == s[i + 3] && s[i] == s[i + 4])
                {
                    Console.WriteLine(true);
                    break;
                }
            }
        }
    }
}

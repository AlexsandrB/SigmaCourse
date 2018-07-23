using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._104
{
    class Program
    {
        static List<char> s;

        static void Main(string[] args)
        {
            s = Console.ReadLine().ToList();
            var count = s.Count - 1;
            for (int i = 0; i < s.Count / 2; i++)
            {
                Swap(i, count - i);
            }
            s.ForEach(c => Console.Write(c));
        }

        private static void Swap(int m, int n)
        {
            var tempM = (int)s[m - 1];
            var tempN = (int)s[n - 1];

            s[m - 1] = (char)tempN;
            s[n - 1] = (char)tempM;
        }
    }
}

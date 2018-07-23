using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._103
{
    class Program
    {
        static List<char> s;

        static void Main(string[] args)
        {
            s = Console.ReadLine().ToList();
            for (int i = 0; i < s.Count - 1; i += 2)
            {
                Swap(i, i + 1);
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

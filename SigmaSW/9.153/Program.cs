using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._153
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().ToList();
            long curCount = 0, maxCount = 0;
            for (int i = 1; i < s.Count; i++)
            {
                if (s[i] == s[i - 1])
                {
                    curCount++;
                }
                else
                {
                    maxCount = maxCount >= curCount ? maxCount : curCount;
                    curCount = 0;
                }
            }
        }
    }
}

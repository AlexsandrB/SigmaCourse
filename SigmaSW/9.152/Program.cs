using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._152
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().ToList();
            long curCount = 0, maxCount = 0;
            s.ForEach(c =>
            {
                if (c == ' ')
                {
                    curCount++;
                }
                else
                {
                    maxCount = maxCount >= curCount ? maxCount : curCount;
                    curCount = 0;
                }
            });

            Console.WriteLine(maxCount);
        }
    }
}

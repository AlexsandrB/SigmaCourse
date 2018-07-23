using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._143
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().ToList();
            if (s.Count(c => c < '0' || c > '9') > 0 || s[0] == '0')
            {
                Console.WriteLine(false);
            }
            else
            {
                Console.WriteLine(true);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._78
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine();
            var sReverse = s.Reverse().ToString();

            Console.WriteLine(String.Compare(s, sReverse) == 0)
        }
    }
}

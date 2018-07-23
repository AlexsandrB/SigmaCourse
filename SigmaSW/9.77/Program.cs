using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._77
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine();
            if (s.IndexOf('а') >= 0)
            {
                Console.WriteLine(s.IndexOf('а'));
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}

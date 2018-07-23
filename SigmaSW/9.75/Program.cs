using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._75
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine();
            if (s.IndexOf(',') >= 0)
            {
                Console.WriteLine(s.Substring(0, s.IndexOf(',')));
            }
            else
            {
                Console.WriteLine(s);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._71
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine();
            Console.WriteLine(s.Count(c => c == 'м') > s.Count(c => c == 'н') ? 'м' : 'н');
        }
    }
}

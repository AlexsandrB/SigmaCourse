using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._54
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine();
            s.ToList().ForEach(c => { if (c == 'м' || c == 'н') { Console.WriteLine(c); } });
        }
    }
}

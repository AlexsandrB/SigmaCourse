using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._73
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine();
            Console.WriteLine(s.LastIndexOf('с') > s.LastIndexOf('т') ? 'с' : 'т');
        }
    }
}

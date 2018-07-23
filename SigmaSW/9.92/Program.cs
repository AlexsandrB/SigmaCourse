using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._92
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().ToList();
            for (int i = 1; i < s.Count; i += 2)
            {
                s[i] = 'ы';
            }
            s.ForEach(c => Console.Write(c));
        }
    }
}

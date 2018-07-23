using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._93
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().ToList();
            for (int i = 2; i < s.Count; i += 3)
            {
                s[i] = 'а';
            }

            s.ForEach(c => Console.Write(c));
        }
    }
}

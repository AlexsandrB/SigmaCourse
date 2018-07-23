using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._154
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<char> set = new SortedSet<char>();
            Console.ReadLine().ToList().ForEach(c => set.Add(c));
            Console.WriteLine(set.Count);
        }
    }
}

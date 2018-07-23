using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._65
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 letter lettering");
            var first = Console.ReadLine();
            Console.WriteLine("Enter lettering");
            var second = Console.ReadLine();
            Console.WriteLine("Sentence");
            var s = Console.ReadLine();
            var count = 0;
            while (s.IndexOf("ро") >= 0)
            {
                count++;
                s.Replace("ро", "");
            }
            Console.WriteLine(count);

            count = 0;
            while (s.IndexOf(first) >= 0)
            {
                count++;
                s.Replace(first, "");
            }
            Console.WriteLine(count);

            count = 0;
            while (s.IndexOf(second) >= 0)
            {
                count++;
                s.Replace(second, "");
            }
            Console.WriteLine(count);
        }
    }
}

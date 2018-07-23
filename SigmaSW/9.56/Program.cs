using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._56
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine();
            while (s.IndexOf("нн") != -1)
            {
                Console.WriteLine("нн");
                s.Replace("нн", "");
            }
        }
    }
}

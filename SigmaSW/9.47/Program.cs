using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._47
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine();
            Int32.TryParse(Console.ReadLine(), out int count);
            for (int i = 0; i < count; i++)
            {
                Console.Write(s);
            }
        }
    }
}

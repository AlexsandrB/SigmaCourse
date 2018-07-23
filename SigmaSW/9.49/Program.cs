using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._49
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine();
            StringBuilder strb = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                strb.Append("*");
            }

            Console.WriteLine(strb.ToString() + s + strb.ToString());
        }
    }
}

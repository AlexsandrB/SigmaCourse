using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._10
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32.TryParse(Console.ReadLine(), out int n);

            StringBuilder strb = new StringBuilder();
            int i = 0;
            for (i = 0; i * i < n; i++)
            {
                strb.Append(i + " ");
            }
            Console.WriteLine(strb.ToString());
            Console.WriteLine(i);
        }
    }
}

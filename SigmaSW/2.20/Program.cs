using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._20
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();

            Console.WriteLine(Convert.ToInt32($"{a[3]}{a[2]}{a[1]}{a[0]}"));

            Console.WriteLine(Convert.ToInt32($"{a[1]}{a[0]}{a[2]}{a[3]}"));

            Console.WriteLine(Convert.ToInt32($"{a[0]}{a[2]}{a[1]}{a[3]}"));

            Console.WriteLine(Convert.ToInt32($"{a[2]}{a[3]}{a[0]}{a[1]}"));

            string b = String.Empty;
            for (int i = 2; i <= 3; i++)
            {
                b += a[i];
            }
            for (int i = 0; i <= 1; i++)
            {
                b += a[i];
            }

            Console.WriteLine(Convert.ToInt32(b));
            Console.ReadKey();
        }
    }
}

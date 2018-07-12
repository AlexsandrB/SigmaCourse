using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._24
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            Console.Write("a = ");
            a = Double.Parse(Console.ReadLine());

            double resa = Math.Sqrt((a * 2 + Math.Sin(Math.Abs(3 * a))) / 3.56);
            Console.WriteLine($"x) = {resa}");


            double x;
            Console.Write("x = ");
            x = Double.Parse(Console.ReadLine());

            double resb = Math.Sin((3.2 + Math.Sqrt(1 + x)) / Math.Abs(x));
            Console.WriteLine($"y) = {resb}");

            Console.ReadKey();

        }
    }
}
 
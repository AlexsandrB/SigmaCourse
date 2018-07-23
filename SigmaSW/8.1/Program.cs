using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder strb = new StringBuilder();
            for (int j = 0; j < 6; j++)
            {
                strb.Append("5 ");
            }
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(strb.ToString());
            }

            Console.WriteLine();
            strb.Clear();
            for (int i = 1; i <= 10; i++)
            {
                strb.Append(i + " ");
            }

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(strb.ToString());
            }

            Console.WriteLine();
            strb.Clear();

            for (int i = 41; i <= 80; i++)
            {
                Console.Write(i + " ");
                if (i % 10 == 0)
                {
                    Console.Write("\n");
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._33
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 100 / 13;
            for (int i = 1; i <= count; i++)
            {
                Console.Write(i * 13 + " ");
            }
        }
    }
}

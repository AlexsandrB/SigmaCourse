using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._4
{
    class Program
    {
        private static string createstring(List<int> list)
        {
            string result = String.Empty;
            list.ForEach(x => result += x + " ");
            return result;
        }

        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int q = i - 1; q >= 0; q--)
                {
                    Console.Write($"{q} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n\n");

            string resultString = String.Empty;
            List<int> diglist = new List<int>() { 6, 5, 4, 3, 2 };
            int startDig = 6;

            Console.WriteLine(createstring(diglist));
                    
            for (int i = 1; i <= 5; i++)
            {

                if (diglist.Count > 1)
                {
                    diglist.RemoveAt(1);
                }
                if (diglist.Count == 1)
                {
                    Console.WriteLine(2);
                    break;
                }

                diglist.RemoveAt(0);
                diglist.Insert(0, startDig + i);

                Console.WriteLine(createstring(diglist));
            }

            Console.WriteLine("\n\n");

            int counter = 30;
            for (int i = 1; i <= 5; i++)
            {
                for (int q = i - 1; q >= 0; q--)
                {
                    Console.Write($"{30 - q} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n\n");

            int startpoint = 20;
            for (int i = 20; i >= 16; i--)
            {
                for (int q = 0; q < i - 15; q++)
                {
                    Console.Write($"{i + q} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n\n");

            Console.ReadLine();
        }
    }
}

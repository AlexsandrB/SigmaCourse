using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var a = input.Split(' ').ToList();
            
            a.RemoveAll(x => a.Count(y => x == y) > 2);

            string result = "";
            a.ForEach(x => result += x + " ");

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}

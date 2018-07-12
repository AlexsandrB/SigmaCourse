using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._8_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var a = input.Split(' ').ToList();
            List<double> numbers = new List<double>();
            a.ForEach(x => numbers.Add(Double.Parse(x)));

            int zeroCount = numbers.Where(x => x == 0).Count();

            numbers.RemoveAll(x => x == 0);
            for (int i = 0; i < zeroCount; i++)
            {
                numbers.Insert(0, 0);
            }

            string result = "";
            numbers.ForEach(x => result += x + " ");
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}

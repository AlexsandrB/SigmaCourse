using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var a = input.Split(' ').ToList();

            List<int> numbers = new List<int>();

            a.ForEach(x => numbers.Add(Int32.Parse(x)));

            int maxIndex = numbers.IndexOf(numbers.Where(y => y % 2 != 0).Max(x => x));
            
            for (int i = 0; i < 3; i++)
            {
                int temp;
                temp = numbers.Last();
                numbers.RemoveAt(numbers.Count - 1);
                numbers.Insert(maxIndex + 1, temp);
            }

            int temp1;

            temp1 = numbers.First();
            numbers.RemoveAt(0);
            numbers.Insert(maxIndex- 1, temp1);

            string result = "";
            numbers.ForEach(x => result += x + " ");
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}

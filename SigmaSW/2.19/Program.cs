using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._19
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int sum = 0;
            int power = 1;
            int oneCount = 0;
            number = Int32.Parse(Console.ReadLine());
            foreach (char digit in number.ToString().ToCharArray())
            {
                if (digit == 1)
                {
                    oneCount++;
                }
                sum += Int32.Parse(digit.ToString());
                power *= Int32.Parse(digit.ToString());
            }

            Console.WriteLine($"sum = {sum}\npower = {power}");
            Console.ReadKey();
        }
    }
}

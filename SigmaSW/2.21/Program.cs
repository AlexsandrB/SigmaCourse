using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._21
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
                if (Convert.ToInt32(digit) == 1)
                {
                    oneCount++;
                }
                sum += Int32.Parse(digit.ToString());
                power *= Int32.Parse(digit.ToString());
            }

            Console.WriteLine($"a) = {number.ToString().ToCharArray()[number.ToString().Length - 1]}\nb) = {number.ToString().ToCharArray()[number.ToString().Length - 2]}");
            Console.ReadKey();
        }
    }
}

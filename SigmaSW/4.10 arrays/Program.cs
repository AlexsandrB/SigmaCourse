using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._10_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var a = input.Split(' ').ToList();
            List<double> numbers = new List<double>();
            a.ForEach(x => numbers.Add(Double.Parse(x)));


        }
    }
}

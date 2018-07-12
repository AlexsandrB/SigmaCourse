using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._5_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var strInput = Console.ReadLine();
            if (strInput.Count(c => c == '0') < 2)
            {
                Console.WriteLine("0");
                return;
            }

            var startIndex = strInput.IndexOf('0');
            strInput = strInput.Remove(startIndex, 1);
            var endIndex = strInput.IndexOf('0');
            strInput = strInput.Remove(startIndex, 1);

            var array = strInput.Substring(startIndex, endIndex - startIndex).Split(' ').Select(c => { Int32.TryParse(c, out int a); return a; }).ToList();
            var res = 0;
            array.ForEach(c => res += c);
            Console.WriteLine(res);
        }
    }
}

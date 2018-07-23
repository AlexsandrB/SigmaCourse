using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._70
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine();
            var letters = "уеаоэяиюёы";
            Console.WriteLine(s.Count(c => letters.IndexOf(c) != -1));
        }
    }
}

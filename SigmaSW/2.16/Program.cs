﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._16
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            Console.WriteLine(Convert.ToInt32($"{a[1]}{a[0]}{a[2]}"));
            Console.ReadKey();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._68
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32.TryParse(Console.ReadLine(), out int n);
            
            Int32.TryParse(Console.ReadLine(), out int k);
            
            Int32.TryParse(Console.ReadLine(), out int a);

            long[,] array = new long[n > k + 1 ? n : k + 1, 2];
            array[0, 0] = 1;
            array[1, 0] = 2;
            array[0, 1] = 1;
            array[1, 1] = 1;

            double sum = 3;
            StringBuilder strb = new StringBuilder();
            strb.Append("1/1;2/1");
            for (int i = 2; i < array.Length; i++)
            {
                array[i, 0] = array[i - 1, 0] + array[i - 2, 0];
                array[i, 1] = array[i - 1, 1] + array[i - 2, 1];
                if (i < n)
                {
                    sum += (array[i, 0] / array[i, 1]);
                    strb.Append($";{array[i, 0]}/{array[i, 1]}");
                }
            }

            Console.WriteLine($"{array[k, 0]}/{array[k, 1]}={array[k, 0] / array[k, 1]}");
            Console.WriteLine(strb.ToString());
            Console.WriteLine(sum > a);
        }
    }
}

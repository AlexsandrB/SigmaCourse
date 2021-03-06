﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._11_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter integer array dividing by whitespace");
            var arr = Console.ReadLine().Split(' ').Select(c => { Int32.TryParse(c, out int a); return a; }).ToArray();
            Console.WriteLine("Enter key value");
            Int32.TryParse(Console.ReadLine(), out int key);
            Array.Sort(arr);
            Console.WriteLine($"Result: {BinarySearch(arr, 0, arr.Length - 1, key)}");
        }

        private static int BinarySearch(int[] array, int left, int right, int key)
        {
            var middle = left + (right - left) / 2;
            if (array[middle] == key)
            {
                return middle;
            }
            else if (array[middle] > key)
            {
                return BinarySearch(array, left, middle, key);
            }
            else
            {
                return BinarySearch(array, middle + 1, right, key);
            }
        }
    }
}

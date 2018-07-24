using System;
using System.Collections.Generic;

namespace Sort
{
    class Program
    {
        private static int[] MainArray = new int[] { 0, 4, 3, 2, 12, 43, 12, 11, -6, 17, 29, -9, 0, 3, 7, 34, 61, -27, 9, -65 };

        #region SelectionSort
        private static void SelectionSort(int[] array)
        {
            int smallestIndex, index, minIndex, temp;

            for (index = 0; index < array.Length - 1; index++)
            {
                smallestIndex = index;

                for (minIndex = index; minIndex < array.Length; minIndex++)
                {
                    if (array[minIndex] < array[smallestIndex])
                    {
                        smallestIndex = minIndex;
                    }
                }
                temp = array[smallestIndex];
                array[smallestIndex] = array[index];
                array[index] = temp;
            }
        }
        #endregion
        #region InsertionSort
        private static void InsertionSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int key = array[i];
                int j = i - 1;
                while (j >= 0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = key;
            }
        }
        #endregion
        #region PyramidSort
        private static int AddElementToPiramid(int[] arr, int i, int N)
        {
            int max;
            int temp;
            if ((2 * i + 2) < N)
            {
                if (arr[2 * i + 1] < arr[2 * i + 2]) max = 2 * i + 2;
                else max = 2 * i + 1;
            }
            else max = 2 * i + 1;
            if (max >= N) return i;
            if (arr[i] < arr[max])
            {
                temp = arr[i];
                arr[i] = arr[max];
                arr[max] = temp;
                if (max < N / 2) i = max;
            }
            return i;
        }
        public static void PyramidSort(int[] arr, int len)
        {
            for (int i = len / 2 - 1; i >= 0; --i)
            {
                long prev_i = i;
                i = AddElementToPiramid(arr, i, len);
                if (prev_i != i) ++i;
            }
            
            int temp;
            for (int k = len - 1; k > 0; --k)
            {
                temp = arr[0];
                arr[0] = arr[k];
                arr[k] = temp;
                int i = 0, prev_i = -1;
                while (i != prev_i)
                {
                    prev_i = i;
                    i = AddElementToPiramid(arr, i, k);
                }
            }
        }
        #endregion
        #region BubbleSort
        private static void BubbleSort(int[] array)
        {
            int len = array.Length;
            int temp;
            bool flag = true;

            for (int i = 1; (i <= (len - 1)) && flag; i++)
            {
                flag = false;
                for (int j = 0; j < (len - 1); j++)
                {
                    if (array[j + 1] > array[j])
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        flag = true;
                    }
                }
            }
        }
        #endregion
        #region QuickSort
        private static void QuickSort(int[] arr, int left, int right)
        {
            PrintArrayAsString(arr, left, right);
            if (left < right)
            {
                int wall = Partition(arr, left, right);
                Console.WriteLine($"wall = {wall}");

                if (wall > 1)
                {
                    QuickSort(arr, left, wall - 1);
                }
                if (wall + 1 < right)
                {
                    QuickSort(arr, wall + 1, right);
                }
            }
        }
        
        private static int Partition(int[] arr, int left, int right)
        {
            //Console.WriteLine("Partition");
            //PrintArrayAsString(arr, left, right);
            int wall = arr[left];
            while (true)
            {
                while (arr[left] < wall) 
                {
                    left++;
                }
                while (arr[right] > wall)
                {
                    right--;
                }
                if (left < right)
                {
                    if (arr[left] == arr[right])
                    {
                        return right;
                    }
                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;
                }
                else
                {
                    return right;
                }
            }
        }
        #endregion
        #region MergeSort
        public static void MergeSort(int[] array, int low, int high)
        {
            PrintArrayAsString(MainArray, low, high);
            if (low < high)
            {
                int middle = (low / 2) + (high / 2);
                MergeSort(array, low, middle);
                MergeSort(array, middle + 1, high);
                Merge(array, low, middle, high);
            }
        }
        
        private static void Merge(int[] array, int low, int middle, int high)
        {
            int left = low;
            int right = middle + 1;
            int[] temp = new int[(high - low) + 1];
            int tempIndex = 0;

            while ((left <= middle) && (right <= high))
            {
                if (array[left] < array[right])
                {
                    temp[tempIndex] = array[left];
                    left = left + 1;
                }
                else
                {
                    temp[tempIndex] = array[right];
                    right = right + 1;
                }
                tempIndex = tempIndex + 1;
            }

            if (left <= middle)
            {
                while (left <= middle)
                {
                    temp[tempIndex] = array[left];
                    left = left + 1;
                    tempIndex = tempIndex + 1;
                }
            }

            if (right <= high)
            {
                while (right <= high)
                {
                    temp[tempIndex] = array[right];
                    right = right + 1;
                    tempIndex = tempIndex + 1;
                }
            }

            for (int i = 0; i < temp.Length; i++)
            {
                array[low + i] = temp[i];
            }

        }
        #endregion

        static void Main(string[] args)
        {
            PrintArrayAsString(MainArray, 0, 19);
            QuickSort(MainArray, 0, MainArray.Length - 1);
            //BubbleSort(MainArray);
            //PyramidSort(MainArray, MainArray.Length);
            //InsertionSort(MainArray);
            //MergeSort(MainArray, 0, MainArray.Length - 1);
            //SelectionSort(MainArray);
            PrintArrayAsString(MainArray, 0, 19);
            Console.ReadKey();
        }

        private static void PrintArrayAsString(int[] array, int from, int to)
        {
            string result = String.Empty;
            for (int count = from; count <= to; count++)
            {
                result += array[count].ToString() + " ";
            }
            Console.WriteLine(result);
        }
    }
}

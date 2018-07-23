using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOnArray
{
    class Program
    {
        public class ArrayList<T> where T : new()
        {
            private T[] MainArray;
            private int Nindex = 0;

            public int Size
            {
                get
                {
                    return MainArray.Length;
                }
            }

            public T this[int index]
            {
                get
                {
                    return MainArray[index];
                }
                set
                {
                    MainArray[index] = value;
                }
            }

            public ArrayList()
            {
                MainArray = new T[100];
            }

            public ArrayList(int size)
            {
                MainArray = new T[size];
            }

            public void Add(T item)
            {
                if (MainArray.Length == Nindex)
                {
                    T[] temp = new T[MainArray.Length * 2];
                    Array.Copy(MainArray, temp, MainArray.Length);
                }
                else
                {
                    MainArray[Nindex] = item;
                    Nindex++;
                }
            }
        }

        static void Main(string[] args)
        {
        }
    }
}

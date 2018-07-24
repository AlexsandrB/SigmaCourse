using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOnArray
{
    class Program
    {
        public class ArrayList<T> where T : IComparable, new()
        {
            private T[] MainArray;
            private int Nindex = 0;

            public int Count
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

            public void AddRange(params T[] items)
            {
                if (MainArray.Length <= Nindex + items.Length)
                {
                    T[] temp = new T[MainArray.Length + items.Length];
                    Array.Copy(MainArray, temp, MainArray.Length);
                    MainArray = temp;
                }
                Array.ConstrainedCopy(items, 0, MainArray, Nindex, items.Length);
                Nindex += items.Length;
            }

            public bool Contains(T item)
            {
                for (int i = 0; i < Nindex; i++)
                {
                    if (MainArray[i].CompareTo(item) == 0)
                    {
                        return true;
                    }
                }
                return false;
            }

            public int IndexOf(T item)
            {
                for (int i = 0; i < Nindex; i++)
                {
                    if (MainArray[i].CompareTo(item) == 0)
                    {
                        return i;
                    }
                }
                return -1;
            }

            public int LastIndexOf(T item)
            {
                for (int i = Nindex - 1; i >= 0; i++)
                {
                    if (MainArray[i].CompareTo(item) == 0)
                    {
                        return i;
                    }
                }
                return -1;
            }

            public T[] ToArray()
            {
                var temp = new T[Nindex];
                Array.ConstrainedCopy(MainArray, 0, temp, 0, Nindex);
                return temp;
            }
        }

        static void Main(string[] args)
        {
        }
    }
}

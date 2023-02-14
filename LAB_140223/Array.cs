using LAB_140223.N2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_140223.N1
{
    internal class MyArray : IOutput, IMath, ISort
    {
        private int[] arr;

        public MyArray(int[] arr)
        {
            this.arr = arr;
        }

        public void Show()
        {
            Console.WriteLine(string.Join(", ", arr));
        }

        public void Show(string info)
        {
            Console.WriteLine(info + ": " + string.Join(", ", arr));
        }

        public int Max()
        {
            return arr.Max();
        }

        public int Min()
        {
            return arr.Min();
        }

        public double Avg()
        {
            return arr.Average();
        }

        public bool Search(int valueToSearch)
        {
            return Array.IndexOf(arr, valueToSearch) >= 0;
        }

        public void SortAsc()
        {
            Array.Sort(arr);
        }

        public void SortDesc()
        {
            Array.Sort(arr);
            Array.Reverse(arr);
        }

        public void SortByParam(bool isAsc)
        {
            if (isAsc) {
                SortAsc();
            } else {
                SortDesc();
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, -3, 5, -387, 0, 7, 3, 345, 8, 4, -8, 3, 0, 1, };

            Console.WriteLine("Original array:");
            array.Print();
            Console.WriteLine();

            array.QuickSort(0, array.Length - 1);

            Console.WriteLine("Sorted array:");
            array.Print();
            Console.WriteLine();
        }
    }
}

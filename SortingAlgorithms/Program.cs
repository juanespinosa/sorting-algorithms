using System;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HEAP SORTING");

            var hs = new HeapSort.HeapSort();

            var A = new int[] { 4, 1, 3, 2, 16, 9, 10, 14, 8, 7 };

            hs.Sort(A);

            foreach (var a in A) Console.Write($"{a} ");
            Console.Read();
        }
    }
}

using SortingAlgorithms.Utils;
using System;

namespace Quicksort
{
    public class QuicksortAlgorithm
    {
        public void Sort(int[] A)
        {
            Quicksort(A, 1, A.Length);
        }

        private void Quicksort(int[] A, int p, int r)
        {
            if(p < r)
            {
                var q = Partition(A, p, r);
                Quicksort(A, p, q - 1);
                Quicksort(A, q + 1, r);
            }
        }

        private int Partition(int[] A, int p, int r)
        {
            var x = A[r - 1]; // pivot
            var i = p - 1;
            for(int j = p; p < r - 1; j++)
            {
                if(A[j - 1] <= x)
                {
                    i++;
                    Common.Exchange(A, i, j);
                }
            }
            Common.Exchange(A, i + 1, r);
            return i + 1;
        }
    }
}

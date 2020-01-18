using SortingAlgorithms.Utils;
using System;

namespace SortingAlgorithms.Quicksort
{
    public class HoareQuicksort : UnpartitionedQuicksort
    {
        public override int Partition(int[] A, int p, int r)
        {
            var x = A[p - 1];
            var i = p - (p <= 1 ? 0 : 1);
            var j = r + (r >= A.Length ? 0 : 1);
            while (true)
            {
                while (A[j - 1] > x)
                {
                    j--;
                }

                while (A[i - 1] < x)
                {
                    i++;
                }

                if (i < j)
                    Common.Exchange(A, i, j);
                else
                    return j;
            }
        }
    }
}

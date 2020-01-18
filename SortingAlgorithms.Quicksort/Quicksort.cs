using SortingAlgorithms.Utils;

namespace Quicksort
{
    public class Quicksort : UnpartitionedQuicksort
    {
        /// <summary>
        /// Create 2 subsets using a pivot value to split
        /// the array
        /// </summary>
        /// <param name="A">The array to be splitted</param>
        /// <param name="p">first element position of the subset</param>
        /// <param name="r">last element position of the subset</param>
        /// <returns>First position of the second subset</returns>
        public override int Partition(int[] A, int p, int r)
        {
            var x = A[r - 1]; // pivot
            var i = p - 1;
            for (int j = p; j <= r - 1; j++)
            {
                if (A[j - 1] <= x)
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

using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms.Utils
{
    public abstract class UnpartitionedQuicksort
    {
        /// <summary>
        /// Calls the quicksort implementation
        /// </summary>
        /// <param name="A">Array to be sorted</param>
        public void Sort(int[] A)
        {
            Sort(A, 1, A.Length);
        }

        /// <summary>
        /// Create 2 subsets using a pivot value to split
        /// the array
        /// </summary>
        /// <param name="A">The array to be splitted</param>
        /// <param name="p">first element position of the subset</param>
        /// <param name="r">last element position of the subset</param>
        /// <returns>First position of the second subset</returns>
        public abstract int Partition(int[] A, int p, int r);

        /// <summary>
        /// Quicksort implementation
        /// </summary>
        /// <param name="A">Array to be sorted</param>
        /// <param name="p">first position</param>
        /// <param name="r">last position</param>
        private void Sort(int[] A, int p, int r)
        {
            if (p < r)
            {
                var q = Partition(A, p, r);
                Sort(A, p, q - 1);
                Sort(A, q + 1, r);
            }
        }
    }
}

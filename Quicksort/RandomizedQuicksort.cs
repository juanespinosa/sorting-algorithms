using SortingAlgorithms.Utils;
using System;

namespace Quicksort
{
    public class RandomizedQuicksort : Quicksort
    {
        private readonly Random _random;

        public RandomizedQuicksort(Random random)
        {
            _random = random;
        }

        /// <summary>
        /// Create 2 subsets using a pivot value to split, but the pivot
        /// value is not the last one by default, but a random position
        /// of the set, and then move it to the last position to reuse
        /// the previous method
        /// </summary>
        /// <param name="A">The array to be splitted</param>
        /// <param name="p">first element position of the subset</param>
        /// <param name="r">last element position of the subset</param>
        /// <returns>First position of the second subset</returns>
        public override int Partition(int[] A, int p, int r)
        {
            var i = _random.Next(p, r + 1);
            Common.Exchange(A, i, r);
            return base.Partition(A, p, r);
        }
    }
}

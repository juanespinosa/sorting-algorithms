namespace SortingAlgorithms.Utils
{
    public class Common
    {
        /// <summary>
        /// Exchange two positions in the array
        /// </summary>
        /// <param name="A">The array with the elements</param>
        /// <param name="posA">Position A to swap</param>
        /// <param name="posB">Position B to Swap</param>
        public static void Exchange(int[] A, int posA, int posB)
        {
            var old = A[posA - 1];
            A[posA - 1] = A[posB - 1];
            A[posB - 1] = old;
        }
    }
}

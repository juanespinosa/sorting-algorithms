namespace HeapSort
{
    /// <summary>
    /// Implementation of a the Heap Sort Algorithm
    /// </summary>
    public class HeapSort
    {
        /// <summary>
        /// Implementation of the Heap Sort Algorithm
        /// </summary>
        /// <param name="A"></param>
        public void Sort(int[] A)
        {
            var heapSize = A.Length;
            BuildMaxHeap(A);
            for (int i = A.Length; i >= 2; i--)
            {
                Exchange(A, 1, i);
                MaxHeapify(A, 1, --heapSize);
            }
        }

        /// <summary>
        /// Creates the Max Heap
        /// </summary>
        /// <param name="A">Array with the elements</param>
        /// <param name="i">position</param>
        /// <param name="n">Heap size</param>
        public void MaxHeapify(int[] A, int i, int n)
        {
            var l = Left(i);
            var r = Right(i);
            int largest;
            if(l <= n && A[l - 1] > A[i - 1])
            {
                largest = l;
            }
            else
            {
                largest = i;
            }

            if(r <= n && A[r - 1] > A[largest - 1])
            {
                largest = r;
            }
            
            if(largest != i)
            {
                Exchange(A, i, largest);
                MaxHeapify(A, largest, n);
            }
        }

        /// <summary>
        /// Exchange two positions in the array
        /// </summary>
        /// <param name="A">The array with the elements</param>
        /// <param name="posA">Position A to swap</param>
        /// <param name="posB">Position B to Swap</param>
        public void Exchange(int[] A, int posA, int posB)
        {
            var old = A[posA - 1];
            A[posA - 1] = A[posB - 1];
            A[posB - 1] = old;
        }

        /// <summary>
        /// Finds the parent position in an array (the one in the middle)
        /// </summary>
        /// <param name="i">Length of the array</param>
        /// <returns>Parent position</returns>
        public int Parent(int i) => i / 2;

        /// <summary>
        /// Create a Heap with the highest (max) number as parent
        /// </summary>
        /// <param name="A">Array with the elements</param>
        private void BuildMaxHeap(int[] A)
        {
            var heapSize = A.Length;
            for(int i = Parent(A.Length); i >= 1; i--)
            {
                MaxHeapify(A, i, heapSize);
            }
        }

        /// <summary>
        /// Finds the left child for a position
        /// </summary>
        /// <param name="i">Parent position</param>
        /// <returns>Left position</returns>
        private int Left(int i) => 2 * i;

        /// <summary>
        /// Finds the right child for a position
        /// </summary>
        /// <param name="i">Parent position</param>
        /// <returns>Right position</returns>
        private int Right(int i) => 2 * i + 1;
    }
}

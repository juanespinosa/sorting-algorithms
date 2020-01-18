using System;

namespace PriorityQueue
{
    public class PriorityQueue
    {
        private int[] _A;

        private readonly HeapSort.HeapSort _hs;
        
        public PriorityQueue()
        {
            _A = new int[0];
            _hs = new HeapSort.HeapSort();
        }

        /// <summary>
        /// Returns the Maximum priority in the queue
        /// </summary>
        /// <returns>int with the max priority</returns>
        public int GetMaximum() 
        {
            if (_A.Length < 1) throw new IndexOutOfRangeException("heap size is 0");
            return _A[0]; 
        }

        /// <summary>
        /// Returns and removes the Maximum priority in the queue
        /// </summary>
        /// <returns>int with the max priority</returns>
        public int ExtractMaximum()
        {
            if (_A.Length < 1) throw new IndexOutOfRangeException("heap size is 0");

            var max = _A[0];
            _A[0] = _A[_A.Length - 1];
            Array.Resize(ref _A, _A.Length - 1);
            _hs.MaxHeapify(_A, 1, _A.Length);
            return max;
        }

        /// <summary>
        /// Increase a position of the queue with a new 
        /// value "key"
        /// </summary>
        /// <param name="i">Position to be updated</param>
        /// <param name="key">New value</param>
        public void IncreaseKey(int i, int key)
        {
            if (key < _A[i - 1]) throw new ArgumentException($"new key ({key}) is smaller than the current key ({_A[i - 1]})");
            _A[i - 1] = key;
            while(i > 1 && _A[_hs.Parent(i) - 1] < _A[i - 1])
            {
                _hs.Exchange(_A, i, _hs.Parent(i));
                i = _hs.Parent(i);
            }
        }
            
        /// <summary>
        /// Insert a new key into the queue
        /// </summary>
        /// <param name="key">Value to be inserted</param>
        public void Insert(int key)
        {
            Array.Resize(ref _A, _A.Length + 1);
            _A[_A.Length - 1] = int.MinValue;
            IncreaseKey(_A.Length, key);
        }

        /// <summary>
        /// Returns the queue
        /// </summary>
        /// <returns>The queue</returns>
        public int[] GetQueue() => _A;
    }
}

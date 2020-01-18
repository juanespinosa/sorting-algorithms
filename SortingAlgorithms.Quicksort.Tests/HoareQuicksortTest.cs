using SortingAlgorithms.Quicksort;
using System;

namespace Quicksort.Tests
{
    public class HoareQuicksortTest : QuicksortTest, IDisposable
    {
        public HoareQuicksortTest()
        {
            _qs = new HoareQuicksort();
        }
    }
}

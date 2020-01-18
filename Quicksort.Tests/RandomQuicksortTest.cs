using System;

namespace Quicksort.Tests
{
    public class RandomizedQuicksortTest : QuicksortTest, IDisposable
    {
        public RandomizedQuicksortTest()
        {
            _qs = new RandomizedQuicksort(new Random());
        }
    }
}

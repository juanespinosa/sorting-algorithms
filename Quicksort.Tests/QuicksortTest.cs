using System;
using Xunit;

namespace Quicksort.Tests
{
    public class QuicksortTest : IDisposable
    {
        private Quicksort _qs;
        private int[] _A;
        private const int _min = -1, _max = 10;

        public QuicksortTest()
        {
            _qs = new Quicksort();
            _A = new int[] { 10, 2, 8, 7, 1, 3, 5, 6, -1, 4 };
            _qs.Sort(_A);
        }

        [Fact]
        public void FirstElementShouldBeTheSmallest()
        {
            Assert.Equal(_min, _A[0]);
        }

        [Fact]
        public void LastElementShouldBeTheLargest()
        {
            Assert.Equal(_max, _A[_A.Length - 1]);
        }

        public void Dispose()
        {
            _qs = null;
            _A = null;
        }
    }
}

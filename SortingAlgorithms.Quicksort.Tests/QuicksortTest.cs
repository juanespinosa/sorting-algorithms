using SortingAlgorithms.Utils;
using System;
using Xunit;

namespace Quicksort.Tests
{
    public class QuicksortTest : IDisposable
    {
        protected UnpartitionedQuicksort _qs;
        protected int[] _A;
        protected const int _min = -1, _max = 10;

        public QuicksortTest()
        {
            _qs = new Quicksort();
            _A = new int[] { 10, 2, 8, 7, 1, 3, 5, 6, -1, 4 };
        }

        [Fact]
        public void FirstElementShouldBeTheSmallest()
        {
            _qs.Sort(_A);
            Assert.Equal(_min, _A[0]);
        }

        [Fact]
        public void LastElementShouldBeTheLargest()
        {
            _qs.Sort(_A);
            Assert.Equal(_max, _A[_A.Length - 1]);
        }

        [Fact]
        public void ShouldBeSorted()
        {
            _qs.Sort(_A);
            for (int i = 1; i < _A.Length; i++)
                Assert.True(_A[i] >= _A[i - 1]);
        }

        public void Dispose()
        {
            _qs = null;
            _A = null;
        }
    }
}

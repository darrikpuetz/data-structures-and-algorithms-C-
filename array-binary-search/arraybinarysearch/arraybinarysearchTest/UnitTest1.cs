using System;
using Xunit;
using static arraybinarysearch.Program;

namespace arraybinarysearchTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5 };
            Assert.Equal(3, ReturnFound(arr, 3));

        }
        [Fact]
        public void Test2()
        {
            int[] arr2 = new int[] { 1, 2, 3, 4, 5 };
            Assert.NotEqual(0, ReturnFound(arr2, 3));

        }
    }
}

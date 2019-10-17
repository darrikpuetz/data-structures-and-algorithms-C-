using System;
using Xunit;
using static array_shift.Program;

namespace XUnitTesarrayshift
{
    public class Test
    {
        [Fact]
        public void Happy()
        {
            int[] oldArray = new int[] { 1, 2, 3, 4 };
            int newNumber = 17;
            int[] newArr = new int[] { 1, 2, 17, 3, 4 };

            Assert.Equal(newArr, ReturnArray(oldArray, newNumber));

        }
    }

}
using System;
using Xunit;
using LinkedListInsert.Classes;

namespace XUnitTestLinkedList
{
    public class UnitTest1
    {
        [Fact]
        public void Append()
        {
            LinkList append = new LinkList();
            append.Append(12);
            Assert.True(append.Head.Value == 12);
        }
    }
}

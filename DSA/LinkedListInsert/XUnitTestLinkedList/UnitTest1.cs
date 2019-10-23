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
            append.Add(1);
            append.Add(45);
            append.Add(64);
            append.Add(25);
            append.Append(3);
            bool worked = append.Worked(12);
            Assert.False(worked);
        }
    }
}

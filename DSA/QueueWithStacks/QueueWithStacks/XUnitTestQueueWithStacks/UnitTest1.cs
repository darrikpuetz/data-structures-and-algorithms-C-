using System;
using Xunit;
using QueueWithStacks;

namespace XUnitTestQueueWithStacks
{
    public class UnitTest1
    {
        [Fact]
        public void TopOfStack()
        {
            Stack newStack = new Stack();
            Node newNode = new Node(13);
            Node secondNode = new Node(15);
            newStack.Push(newNode);
            newStack.Push(secondNode);
            Assert.Equal(newStack.First.Value, secondNode.Value);
        }

        [Fact]
        public void NotTop()
        {
            Stack newStack = new Stack();
            Node newNode = new Node(13);
            Node secondNode = new Node(15);
            newStack.Push(newNode);
            newStack.Push(secondNode);
            Assert.NotEqual(newStack.First.Value, newNode.Value);
        }

        [Fact]
        public void Remove()
        {
            Stack newStack = new Stack();
            Node newNode = new Node(2);
            Node secondNode = new Node(5);
            Node thirdNode = new Node(71);
            newStack.Push(newNode);
            newStack.Push(secondNode);
            newStack.Push(thirdNode);
            newStack.Pop();
            Assert.True(newStack.StackSize == 2);
        }
    }
}

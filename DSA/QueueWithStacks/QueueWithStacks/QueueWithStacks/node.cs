using System;
using System.Collections.Generic;
using System.Text;

namespace QueueWithStacks
{
    public class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }

        public Node() { }
        public Node(int value)
        {
            Value = value;
        }
    }
}
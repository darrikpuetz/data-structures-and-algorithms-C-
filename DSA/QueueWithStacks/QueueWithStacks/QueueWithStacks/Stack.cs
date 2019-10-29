using System;
using System.Collections.Generic;
using System.Text;

namespace QueueWithStacks
{
    public class Stack
    {
        public Node First { get; set; }
        public int StackSize { get; set; }

        public void Push(Node node)
        {
            node.Next = First;
            First = node;
            StackSize++;
        }
        public Node Pop()
        {
            Node hold = new Node();
            hold = First;
            First = hold.Next;
            hold.Next = null;
            StackSize--;
            return hold;
        }
        public Node Peek()
        {
            return First;
        }
    }
}

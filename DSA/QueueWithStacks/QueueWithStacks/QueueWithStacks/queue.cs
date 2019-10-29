using System;
using System.Collections.Generic;
using System.Text;

namespace QueueWithStacks
{
    public class Queue
    {
        public Node Current { get; set; }
        public Node Previous { get; set; }
        public int NodeSize { get; set; }


        public void Enqueue(Node newNode)
        {
            if (Current == null)
            {
                Current = newNode;
                Previous = newNode;
            }
            else
            {
                Previous.Next = newNode;
                Previous = newNode;
            }
            NodeSize++;
        }
        public Node Dequeue()
        {
            Node newNode = new Node();
            newNode = Current;
            Current = Current.Next;
            newNode = null;
            return newNode;
        }

        public Node Peek()
        {
            return Current;
        }
    }
}

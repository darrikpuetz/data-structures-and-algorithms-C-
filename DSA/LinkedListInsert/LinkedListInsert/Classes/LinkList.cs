using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListInsert.Classes
{
    public class LinkList
    {
        public Node Head { get; set; }
        public Node Current { get; set; }


        public void Append(int value)
        {
            Current = Head;
            while (Current.Next != null)
            {
                Current = Current.Next;
            }
            Node node = new Node(value);
            Current.Next = node;
        }

        public void InsertBefore(int value, int value2)
        {
            Current = Head;
            if (Current.Value == value)
            {
                Node newNode = new Node(value2);
                newNode.Next = Head;
                Head = newNode;
                Current = Head;
                return;
            }
            while (Current.Next != null)
            {
                if (Current.Next.Value == value)
                {
                    Node node = new Node(value2);
                    node.Next = Current.Next;
                    Current.Next = node;
                    return;
                }
                Current = Current.Next;
            }
        }
        public void InsertAfter(int value, int value2)
        {
            Current = Head;
            if (Current.Value == value)
            {
                Node newNode = new Node(value2);
                newNode.Next = Current.Next;
                Current.Next = newNode;
                return;
            }
            while (Current.Next != null)
            {
                if (Current.Value == value)
                {
                    Node node = new Node(value2);
                    node.Next = Current.Next;
                    Current.Next = node;
                    return;                    
                }
                Current = Current.Next;
            }
            if (Current.Value == value)
            {
                    Node node = new Node(value2);
                    node.Next = Current.Next;
                    Current.Next = node;
                    return;
            }
        }
    }

}

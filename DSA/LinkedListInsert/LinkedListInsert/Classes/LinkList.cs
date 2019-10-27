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
        public string ToString(int value)
        {
            StringBuilder toString = new StringBuilder();
            Current = Head;
            while (Current != null)
            {
                toString.Append(Current.Value);
                if (Current.Next != null)
                {
                    toString.Append(" , ");
                    Current = Current.Next;
                }
            }
            return toString.ToString();
        }
        public void Insert(int value)
        {
            Node node = new Node(value) { Next = Head };
            Head = node;
        }
        public bool Includes(int value)
        {
            Current = Head;
            while (Current.Next != null)
            {
                Current = Current.Next;
            }
            if (Current.Value == value)
            {
                return true;
            }
            else
            {
                Current = Current.Next;
            }
            return false;
        }


        public void Add(int value)
        {
            Node newNode = new Node(value);
            newNode.Next = Head;
            Head = newNode;
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
        public bool Worked(int value)
        {
            Current = Head;
            while (Current.Next != null)
            {
                if (Current.Value == value)
                {
                    return true;
                }
                Current = Current.Next;
            }
            if (Current.Value == value)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Node Merge(LinkList listOne, LinkList listTwo)
        {
            Node firstNode = listOne.Head;
            Node secondNode = listTwo.Head;
            Node tailOne = null;
            Node tailTwo = null;

            while (firstNode != null && secondNode != null)
            {
                tailOne = firstNode.Next;
                firstNode.Next = secondNode;
                if (tailOne == null)
                {
                    break;
                }
                tailTwo = secondNode;
                secondNode.Next = tailOne;
                firstNode = tailOne;
                secondNode = tailTwo;
            }
            if (listOne.Head == null)
            {
                return listOne.Head;
            }
            else
            {
                return listTwo.Head;
            }

        }
    }

}

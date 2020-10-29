using System;
using System.Collections.Generic;

namespace StackandQueue.DataStructures
{
    public class Queue
    {
        public LinkedList<int> list;

        public Queue()
        {
            this.list = new LinkedList<int>();
        }

        public int Count()
        {
            return this.list.Count;
        }

        public LinkedListNode<int> Enqueue(int num)
        {
            return this.list.AddLast(num);
        }

        public LinkedListNode<int> Dequeue()
        {
            LinkedListNode<int> firstNode = this.list.First;
            this.list.RemoveFirst();
            return firstNode;
        }

        public LinkedListNode<int> Peek()
        {
            return this.list.First;
        }

    }
}

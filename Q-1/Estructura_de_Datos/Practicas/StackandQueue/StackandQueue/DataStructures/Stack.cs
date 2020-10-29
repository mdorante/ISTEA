using System.Collections.Generic;

namespace StackandQueue.DataStructures
{
    public class Stack
    {
        public LinkedList<int> list;

        public Stack()
        {
            this.list = new LinkedList<int>();
        }

        public int Count()
        {
            return this.list.Count;
        }

        public LinkedListNode<int> Push(int num)
        {
            return this.list.AddLast(num);
        }

        public LinkedListNode<int> Pop()
        {
            LinkedListNode<int> lastNode = this.list.Last;
            this.list.RemoveLast();
            return lastNode;
        }

        public LinkedListNode<int> Peek()
        {
            return this.list.Last;
        }

    }
}
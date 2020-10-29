using System.Collections.Generic;

namespace StackandQueue.DataStructures
{
    public class Stack
    {
        public LinkedList<string> list;

        public Stack()
        {
            this.list = new LinkedList<string>();
        }

        public int Count()
        {
            return this.list.Count;
        }

        public LinkedListNode<string> Push(string num)
        {
            return this.list.AddLast(num);
        }

        public LinkedListNode<string> Pop()
        {
            LinkedListNode<string> lastNode = this.list.Last;
            this.list.RemoveLast();
            return lastNode;
        }

        public LinkedListNode<string> Peek()
        {
            return this.list.Last;
        }

    }
}
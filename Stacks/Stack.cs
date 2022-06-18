using System;

namespace Stacks
{
    public class Stack<T>
    {
        public int Count;
        private class StackNode<T>
        {
            public T data;
            public StackNode<T> next;

            public StackNode(T data)
            {
                this.data = data;
            }
        }

        private StackNode<T> top;

        public T pop()
        {
            if (top == null) throw new Exception();

            T item = top.data;
            top = top.next;

            return item;
        }

        public void push(T item)
        {
            StackNode<T> t = new StackNode<T>(item);

            t.next = top;
            top = t;

            Count++;
        }

        public T peek()
        {
            if (top == null) throw new Exception();

            return top.data;
        }

        public Boolean isEmpty()
        {
            return top == null;
        }
    }
}

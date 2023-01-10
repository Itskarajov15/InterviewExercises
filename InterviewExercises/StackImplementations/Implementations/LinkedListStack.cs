using StackImplementations.Contracts;

namespace StackImplementations.Implementations
{
    public class LinkedListStack<T> : IStack<T>
    {
        private class Node
        {
            public Node(T value, Node next)
            {
                this.Value = value;
                this.Next = next;
            }

            public T Value { get; set; }

            public Node Next { get; set; }
        }

        private Node top;

        public T Pop()
        {
            if (top == null)
            {
                throw new InvalidOperationException("The stack is empty");
            }

            var temp = top;
            top = top.Next;

            return temp.Value;
        }

        public void Push(T item)
        {
            var node = new Node(item, top);
            top = node;
        }
    }
}
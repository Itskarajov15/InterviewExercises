using QueueImplementations.Contracts;

namespace QueueImplementations.Implementations
{
    public class LinkedListQueue<T> : IQueue<T>
    {
        private class Node
        {
            public Node(T value)
            {
                this.Value = value;
                this.Next = null;
            }

            public T Value { get; set; }

            public Node Next { get; set; }
        }

        private Node head;
        private Node tail;

        public T Dequeue()
        {
            if (this.head == null)
            {
                throw new InvalidOperationException("The queue is empty");
            }

            var itemToRemove = this.head;

            this.head = itemToRemove.Next;

            if (this.head == null)
            {
                this.tail = null;
            }

            return itemToRemove.Value;
        }

        public void Enqueue(T item)
        {
            var node = new Node(item);

            if (this.tail == null)
            {
                this.head = node;
                this.tail = node;
            }
            else
            {
                this.tail.Next = node;
                this.tail = node;
            }
        }
    }
}
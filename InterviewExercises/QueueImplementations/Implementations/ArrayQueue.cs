using QueueImplementations.Contracts;

namespace QueueImplementations.Implementations
{
    public class ArrayQueue<T> : IQueue<T>
    {
        private T[] queue;
        private int maxSize;
        private int currentSize = 0;
        private int head = 0;
        private int tail = 0;

        public ArrayQueue(int size)
        {
            this.maxSize = size;
            this.queue = new T[size];
        }

        public T Dequeue()
        {
            if (this.currentSize == 0)
            {
                throw new InvalidOperationException("The queue is empty");
            }

            var itemToRemove = this.queue[head++];

            if (this.head == this.maxSize)
            {
                this.head = 0;
            }

            this.currentSize--;

            return itemToRemove;
        }

        public void Enqueue(T item)
        {
            if (this.currentSize >= this.maxSize)
            {
                throw new InvalidOperationException("The queue is full");
            }

            if (this.tail == this.maxSize)
            {
                this.tail = 0;
            }

            this.queue[this.tail++] = item;
            this.currentSize++;
        }
    }
}
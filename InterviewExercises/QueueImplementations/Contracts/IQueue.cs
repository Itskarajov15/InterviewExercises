namespace QueueImplementations.Contracts
{
    public interface IQueue<T>
    {
        void Enqueue(T item);

        T Dequeue();
    }
}
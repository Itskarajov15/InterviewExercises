using StackImplementations.Contracts;

namespace StackImplementations.Implementations
{
    public class ArrayStack<T> : IStack<T>
    {
        private int top = -1;
        private T[] stack;
        private int size;

        public ArrayStack(int size)
        {
            this.size = size;
            stack = new T[size];
        }

        public void Push(T item)
        {
            top += 1;

            if (top >= size)
            {
                top--;
                throw new InvalidOperationException("The stack is full");
            }

            stack[top] = item;
        }

        public T Pop()
        {
            if (top < 0)
            {
                throw new InvalidOperationException("The stack is empty");
            }

            var itemToRemove = stack[top];
            top--;

            return itemToRemove;
        }
    }
}
﻿namespace StackImplementations.Contracts
{
    public interface IStack<T>
    {
        void Push(T item);

        T Pop();
    }
}
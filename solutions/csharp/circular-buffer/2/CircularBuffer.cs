using System;
using System.Collections.Generic;

public class CircularBuffer<T>(int capacity) : Queue<T>
{
    public T Read() => Count == 0 ? throw new InvalidOperationException() : Dequeue();

    public void Write(T value)
    {
        if (Count == capacity)
            throw new InvalidOperationException();

        Enqueue(value);
    }

    public void Overwrite(T value)
    {
        if (Count == capacity)
            Dequeue();

        Enqueue(value);
    }
}
using System;
using System.Collections.Generic;
using System.Linq;

public class CircularBuffer<T>(int capacity)
{
    private List<T> _items = new(capacity);

    public T Read()
    {
        if (_items.Count == 0) 
            throw new InvalidOperationException();

        var value = _items[0];

        DequeueHead();

        return value;
    }

    public void Write(T value)
    {
        if (_items.Count == capacity)
            throw new InvalidOperationException();

        _items.Add(value);
    }

    public void Overwrite(T value)
    {
        if (_items.Count == capacity) 
            DequeueHead();

        Write(value);
    }

    public void Clear() => _items.Clear();

    private void DequeueHead() => _items = _items.Skip(1).ToList();
}
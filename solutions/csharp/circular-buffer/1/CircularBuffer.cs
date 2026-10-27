public class CircularBuffer<T>
{
    private T[] items;
    private int head;
    private int tail;
    private int count;
    
    public CircularBuffer(int capacity)
    {
        items = new T[capacity];
        head = 0;
        tail = 0;
        count = 0;
    }
    public T Read()
    {
        if (count == 0)
        {
            throw new InvalidOperationException("Buffer is empty.");
        }
        T item = items[head];
        head = (head + 1) % items.Length;
        count--;
        return item;
    }
    public void Write(T value)
    {
        if(count == items.Length)
            throw new InvalidOperationException("Buffer is full.");
        items[tail] = value;
        tail = (tail + 1) % items.Length;
        count++;
    }
    public void Overwrite(T value)
    {
        if (count == items.Length)
        {
            items[tail] = value;
            tail = (tail + 1) % items.Length;
            head = (head + 1) % items.Length;
        }
        else
        {
            Write(value);
        }
    }
    public void Clear()
    {
        Array.Clear(items);
        head = 0;
        tail = 0;
        count = 0;
    }
}
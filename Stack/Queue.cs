using System;

public class Queue<T>
{
    private class QueueItem
    {
        public T Value { get; }
        public QueueItem Next { get; set; }

        public QueueItem(T value)
        {
            Value = value;
        }
    }

    private QueueItem _head;
    private QueueItem _tail;

    public void Enqueue(T value)
    {
        var newItem = new QueueItem(value);
        if (_head == null)
        {
            _head = newItem;
            _tail = newItem;
        }
        else
        {
            _tail.Next = newItem;
            _tail = newItem;
        }
    }

    public T Dequeue()
    {
        if (_head == null)
        {
            throw new InvalidOperationException("Queue is empty");
        }
        var value = _head.Value;
        _head = _head.Next;
        return value;
    }

    public T Peek()
    {
        if (_head == null)
        {
            throw new InvalidOperationException("Queue is empty");
        }
        return _head.Value;
    }

    public bool IsEmpty()
    {
        return _head == null;
    }
}
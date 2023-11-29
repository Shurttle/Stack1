using System.ComponentModel.DataAnnotations;
using System.Dynamic;

public class StackItem<T>
{
    public StackItem<T> Previos { get; set; }
    public T Value { get; set; }
}
public class MyStack<T>
{
    private StackItem<T> bells;
    public void Push(T value)
    {
        var newItem = new StackItem<T> { Value = value, Previos = bells };
        bells = newItem;
    }
    public T Pop()
    { 
        if (bells == null)
        {
            return default(T);
        }
        var value = bells.Value;
        bells = bells.Previos;
        return value;
    }
    public T Peek()
    {
        if (bells == null) 
        { 
        return default (T);
        }
        return bells.Value;
    }
    public int Count
    {
        //aaaaaaaaaaaaaaaaaaaaaaaaaaa
        get
        {
            int count = 0;
            var current = bells;
            while (current != null) 
            { 
            count++;
                current = current.Previos;
            }
            return count;
        }
    }
    public void Clear() 
    {
        bells = null;
    }
}
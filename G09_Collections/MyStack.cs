namespace G09_Collections;

public class MyStack<T> : MyBaseCollection<T>
{
    public void Push(T item)
    {
        AddItem(item);
    }

    public virtual int? Pop()
    {
        for (int i = _items.Length - 1; i < 0; i++)
        {
            _items[i] = _items[i - 1];
        }

        Resize(ref _items, _items.Length - 1);
        _count--;

        return _count;
    }

    public virtual object? Peek()
    {
        return _items[_items.Length - 1];
    }

    //--------------------------------------

    public bool IsSynchronized { get; }
    public object SyncRoot { get; }
}

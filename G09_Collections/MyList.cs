namespace G09_Collections;

public class MyList<T> : MyBaseCollection<T>, IList<T>
{
    public void Add(T item)
    {
        AddItem(item);
    }

    public int IndexOf(T item)
    {
        for (int i = 0; i < _items.Length; i++)
        {
            if (_items[i].Equals(item))
            {
                return i;
            }
        }

        return -1;
    }

    public void Insert(int index, T item)
    {
        if (index > _count)
        {
            throw new IndexOutOfRangeException();
        }

        Resize(ref _items, _items.Length + 1);

        for (int i = _items.Length - 1; i > index; i--)
        {
            _items[i] = _items[i - 1];
        }

        _items[index] = item;
    }

    public void Remove(T? item)
    {
        int index = IndexOf(item);

        if (index != -1)
        {
            RemoveAt(index);
        }
    }

    public void RemoveAt(int index)
    {
        for (int i = index; i < _items.Length - 1; i++)
        {
            _items[i] = _items[i + 1];
        }

        Resize(ref _items, _items.Length - 1);
        _count--;
    }

    public T this[int index]
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }
}

namespace G09_Collections;

public class MyQueue<T> : MyBaseCollection<T>
{
    public void Enqueue(T? value)
    {
        if (_count == _items.Length)
        {
            Resize(ref _items, _items.Length * 2);
        }

        _count++;
        _items[_count - 1] = value;
    }

    public virtual int Dequeue()
    {
        for (int i = 0; i < _items.Length - 1; i++)
        {
            _items[i] = _items[i + 1];
        }

        Resize(ref _items, _items.Length - 1);
        _count--;

        return _count;
    }

    public virtual int Peek<T>(T? value)
    {
        return IndexOf(value, 0);
    }

    //---------------------------------->

    public int IndexOf<T>(T? value)
    {
        return IndexOf(value, 0);
    }

    public int IndexOf<T>(T? value, int startIndex)
    {
        for (int i = startIndex; i < _items.Length; i++)
        {
            if (_items[i].Equals(value))
            {
                return i;
            }
        }

        return -1;
    }
}

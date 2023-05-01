using System.Collections;

namespace G09_Collections;

public abstract class MyBaseCollection<T> : ICollection<T>, IEnumerable, IEnumerator
{
    protected T?[] _items;
    protected int _count;
    private int _index;

    public IEnumerator GetEnumerator()
    {
        _index = -1;
        return this;
    }


    public MyBaseCollection()
    {
        _items = new T?[4];
        _count = 0;
    }

    public object? Get(int index)
    {
        return _items[index];
    }

    protected void AddItem(T item)
    {
        if (_count == _items.Length)
        {
            Resize(ref _items, _items.Length * 2);
        }

        _count++;
        _items[_count - 1] = item;

        //return _count - 1;
    }

    void ICollection<T>.Add(T item)
    {
        throw new NotImplementedException();
    }

    public void Clear()
    {
        _items = new T?[4];
        _count = 0;
    }

    public bool Contains(T item)
    {
        for (int i = 0; i < _items.Length; i++)
        {
            if (_items[i].Equals(item))
            {
                return true;
            }
        }

        return false;
    }

    public void CopyTo(T[] array, int arrayIndex)
    {
        throw new NotImplementedException();
    }

    bool ICollection<T>.Remove(T item)
    {
        if (!Contains(item))
        {
            return false;
        }

        for (int i = 0; i < _items.Length - 1; i++)
        {
            _items[i] = _items[i + 1];
        }
        Resize(ref _items, _items.Length - 1);

        return true;
    }

    public int Count => _count;

    public bool MoveNext()
    {
        if (_index < _items.Length - 1)
        {
            _index++;
            return true;
        }

        return false;
    }

    public void Reset()
    {
        _index = -1;
    }

    public object? Current => _items[_index];

    IEnumerator<T> IEnumerable<T>.GetEnumerator()
    {
        return ((IEnumerable<T>)_items).GetEnumerator();
    }

    //------------------------------------------------->
    public bool IsReadOnly { get; }


    protected static void Resize<T>(ref T?[] array, int size)
    {
        if (array == null)
            throw new ArgumentNullException(nameof(array));
        if (array.Length == size)
            return;

        T?[] temp = new T?[size];
        int length = array.Length < temp.Length ? array.Length : temp.Length;

        for (int i = 0; i < length; i++)
        {
            temp[i] = array[i];
        }

        array = temp;
    }
}

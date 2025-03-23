

namespace Pattern_03.Iterator;

public class ListCollection<T> : IListCollection<T>
{
    private List<T> _items = new List<T>();

    public void Add(T item)
    {
        _items.Add(item);
    }

    public IIterator<T> CreateIterator()
    {
        return new ListIterator<T>(this);
    }

    public int Count => _items.Count;

    public T GetItem(int index)
    {
        return _items[index];
    }
}

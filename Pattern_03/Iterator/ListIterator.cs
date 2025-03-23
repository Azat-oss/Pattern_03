

namespace Pattern_03.Iterator;

public class ListIterator<T>:IIterator<T>
{
    private ListCollection<T> _collection;
    private int _currentIndex = 0;

    public ListIterator(ListCollection<T> collection)
    {
        _collection = collection;
    }

    public bool HasNext()
    {
        return _currentIndex < _collection.Count;
    }

    public T Next()
    {
        return _collection.GetItem(_currentIndex++);
    }
}

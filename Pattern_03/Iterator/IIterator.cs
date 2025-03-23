
namespace Pattern_03.Iterator;

public interface IIterator<T>
{
    bool HasNext();
    T Next();
}

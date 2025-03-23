
namespace Pattern_03.Iterator;

public interface IListCollection<T>
{
    IIterator<T> CreateIterator();

}

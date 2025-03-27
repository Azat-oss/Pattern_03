namespace ConsoleApp11.Composite;

public abstract class Component
{
    public abstract void Display();
    public abstract void Add(Component component);
    public abstract void Remove(Component component);
}

namespace ConsoleApp11.Composite;
public class Symbol1 : Component
{
    private List<Component> components;

    public Symbol1()
    {
        components = new List<Component>();
    }

    public override void Add(Component component)
    {
        components.Add(component);
    }

    public override void Display()
    {
        for (int i = 0; i < components.Count; i++)
        {
            components[i].Display();
        }
    }

    public override void Remove(Component component)
    {
        components.Remove(component);
    }
}

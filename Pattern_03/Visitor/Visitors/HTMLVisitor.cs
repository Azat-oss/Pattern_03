using ConsoleApp11.Visitor.Clients;

namespace ConsoleApp11.Visitor.Visitors;

public class HTMLVisitor : IVisitor
{
    public string Serialize(Company company)
    {
        return string.Empty;
    }

    public string Serialize(Person person)
    {
        return string.Empty;
    }
}

using ConsoleApp11.Visitor.Visitors;

namespace ConsoleApp11.Visitor.Clients;

public class Company : IClient
{
    public string Title { get; set; }
    public string RegNumber { get; set; }

    public string Accept(IVisitor visitor)
    {
        return visitor.Serialize(this);
    }
}
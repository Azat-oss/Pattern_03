using ConsoleApp11.Visitor.Visitors;

namespace ConsoleApp11.Visitor.Clients;

public interface IClient
{
    public string Accept(IVisitor visitor);
}

using ConsoleApp11.Visitor.Clients;

namespace ConsoleApp11.Visitor.Visitors;

public interface IVisitor
{
    string Serialize(Company company);
    string Serialize(Person person);
}

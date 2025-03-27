using ConsoleApp11.Visitor.Clients;

namespace ConsoleApp11.Visitor.Visitors;

class Class1 : IVisitor
{
    public string Serialize(Company company)
    {
        throw new NotImplementedException();
    }

    public string Serialize(Person person)
    {
        throw new NotImplementedException();
    }
}

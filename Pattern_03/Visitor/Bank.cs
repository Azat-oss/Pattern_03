using ConsoleApp11.Visitor.Clients;
using ConsoleApp11.Visitor.Visitors;

namespace ConsoleApp11.Visitor;

public class Bank
{
    private List<IClient> clients;

    public Bank()
    {
        clients = new List<IClient>();
    }

    public void Add(IClient client)
    {
        clients.Add(client);
    }

    public void Remove(IClient client)
    {
        clients.Remove(client);
    }

    public void SaveDataBase(IVisitor visitor)
    {
        for (int i = 0; i < clients.Count; i++)
        {
            var serializeClient = clients[i].Accept(visitor);
            //...Запись в бд
        }
    }
}
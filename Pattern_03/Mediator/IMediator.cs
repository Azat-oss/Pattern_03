

namespace Pattern_03.Mediator;

public interface IMediator
{
    void Send(string message, Colleague colleague);
}

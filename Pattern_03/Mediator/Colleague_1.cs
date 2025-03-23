

namespace Pattern_03.Mediator;

public class Colleague_1 : Colleague
{
    public Colleague_1(IMediator mediator) : base(mediator) { }

    public void Send(string message)
    {
        Console.WriteLine($"Коллега_1 отправляет: {message}");
        _mediator.Send(message, this);
    }

    public override void Receive(string message)
    {
        Console.WriteLine($"Коллега_1 получил: {message}");
    }
}

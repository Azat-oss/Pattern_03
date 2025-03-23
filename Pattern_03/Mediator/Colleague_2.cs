

namespace Pattern_03.Mediator;

public class Colleague_2 : Colleague
{
    public Colleague_2(IMediator mediator) : base(mediator) { }

    public void Send(string message)
    {
        Console.WriteLine($"Коллега_2 отправляет: {message}");
        _mediator.Send(message, this);
    }

    public override void Receive(string message)
    {
        Console.WriteLine($"Коллега_2 получил: {message}");
    }
}

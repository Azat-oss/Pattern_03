
namespace Pattern_03.Mediator;

public abstract class Colleague
{
    protected IMediator _mediator;

    protected Colleague(IMediator mediator)
    {
        _mediator = mediator;
    }

    public abstract void Receive(string message);
}

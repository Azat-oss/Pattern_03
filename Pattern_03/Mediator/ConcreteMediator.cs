

namespace Pattern_03.Mediator;

internal class ConcreteMediator:IMediator
{
    private Colleague_1 _colleague_1;
    private Colleague_2 _colleague_2;

    public void SetColleague_1(Colleague_1 colleague_1)
    {
        _colleague_1 = colleague_1;
    }

    public void SetColleague_2(Colleague_2 colleague_2)
    {
        _colleague_2 = colleague_2;
    }

    public void Send(string message, Colleague colleague)
    {
        if (colleague == _colleague_1)
        {
            _colleague_2.Receive(message);
        }
        else if (colleague == _colleague_2)
        {
            _colleague_1.Receive(message);
        }
    }
}

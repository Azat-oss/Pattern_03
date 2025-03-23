

namespace Pattern_03.Chain_of_Responsibility;

abstract class Handler
{
    protected Handler _nextHandler;

    public void SetNext(Handler nextHandler)
    {
        _nextHandler = nextHandler;
    }

    public abstract void HandleRequest(Request request);
}

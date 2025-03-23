

namespace Pattern_03.Chain_of_Responsibility;

 class HandlerA: Handler
{
    public override void HandleRequest(Request request)
    {
        if (request.Level == 1)
        {
            Console.WriteLine("Handler_A отправлен запрос level 1.");
        }
        else if (_nextHandler != null)
        {
            _nextHandler.HandleRequest(request);
        }
    }
}

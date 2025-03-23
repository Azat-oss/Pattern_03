

namespace Pattern_03.Chain_of_Responsibility;

 class HandlerB : Handler
{
    public override void HandleRequest(Request request)
    {
        if (request.Level == 2)
        {
            Console.WriteLine("Handler_B отправлен запрос level 2.");
        }
        else if (_nextHandler != null)
        {
            _nextHandler.HandleRequest(request);
        }
    }
}

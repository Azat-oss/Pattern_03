

namespace Pattern_03.Chain_of_Responsibility;

 class HandlerC : Handler
{
    public override void HandleRequest(Request request)
    {
        if (request.Level == 3)
        {
            Console.WriteLine("Handler_C отправлен запрос level 3.");
        }
        else if (_nextHandler != null)
        {
            _nextHandler.HandleRequest(request);
        }
    }
}

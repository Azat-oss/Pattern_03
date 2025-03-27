namespace ConsoleApp11.Decorator;

public class ValidationRequest : IServerApi
{
    private IServerApi _serverApi;
    private string _arg1;
    private string _arg2;

    public ValidationRequest(IServerApi serverApi)
    {
        _arg1 = arg1;
        _arg2 = arg2;

        _serverApi = serverApi;
    }

    public Data Get()
    {
        if (_arg1.Length <= 256 && _arg2.Length <= 256)
        {
            return _serverApi.Get();
        }

        throw new Exception();
    }
}

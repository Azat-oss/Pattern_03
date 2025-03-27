namespace ConsoleApp11.Decorator;

public class ServerApi : IServerApi
{
    public Data Get()
    {
        //new HttpClient().GetAsync();
        var data = new Data();
        data.Property1 = 1;
        data.Property1 = 2;

        return data;
    }
}
namespace ConsoleApp11.Proxy;

public class MyProxy : Subject
{
    private RealSubject realSubject;

    public MyProxy()
    {
        realSubject = new RealSubject();
    }

    public override void SomeAction()
    {
        ///...
        ///
        ///Log.Information("");
        ///Валидация
        ///

        realSubject.SomeAction();
    }
}


namespace Pattern_03.TemplateMethod;

abstract class AbstractClass
{
    public void TemplateMethod()
    {
        Step1();
        Step2();
        Step3();
    }

    protected abstract void Step1();
    protected abstract void Step2();
    protected virtual void Step3()
    {
        Console.WriteLine("Шаг 3 из базового класса");
    }
}

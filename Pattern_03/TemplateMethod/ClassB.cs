

namespace Pattern_03.TemplateMethod;

 class ClassB: AbstractClass
{
    protected override void Step1()
    {
        Console.WriteLine("ClassB: Шаг 1");
    }

    protected override void Step2()
    {
        Console.WriteLine("ClassB: Шаг 2");
    }

    protected override void Step3()
    {
        Console.WriteLine("ClassB: Шаг 3 (переопределено)");
    }
}

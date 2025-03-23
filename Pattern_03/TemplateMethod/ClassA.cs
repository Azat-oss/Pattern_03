

namespace Pattern_03.TemplateMethod;

class ClassA:AbstractClass
{
    protected override void Step1()
    {
        Console.WriteLine("ClassA: Шаг 1");
    }

    protected override void Step2()
    {
        Console.WriteLine("ClassA: Шаг 2");
    }
}

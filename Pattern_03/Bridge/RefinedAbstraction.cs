

namespace Pattern_03.Bridge;

public class RefinedAbstraction : Abstraction
{
    public RefinedAbstraction(IImplementation implementation) : base(implementation)
    {
    }

    public override void Operation()
    {
        Console.WriteLine("RefinedAbstraction: Operation");
        implementation.ImplementationMethod();
    }
}

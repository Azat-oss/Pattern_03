
namespace Pattern_03.Bridge;

public abstract class Abstraction
{
    protected IImplementation implementation;

    protected Abstraction(IImplementation implementation)
    {
        this.implementation = implementation;
    }

    public abstract void Operation();
}

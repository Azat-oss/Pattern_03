using ConsoleApp11.Facade.Subsystem;

namespace ConsoleApp11.Facade;

public class Facade
{
    private SubsystemA _subsystemA;
    private SubsystemB _subsystemB;
    private SubsystemC _subsystemC;

    public Facade(SubsystemA subsystemA, SubsystemB subsystemB, SubsystemC subsystemC)
    {
        _subsystemA = subsystemA;
        _subsystemB = subsystemB;
        _subsystemC = subsystemC;
    }

    public void Operation1()
    {
        _subsystemA.OperationA();
        _subsystemB.OperationB();
        _subsystemC.OperationC();
    }

    public void Operation2()
    {
        _subsystemC.OperationC();
        _subsystemB.OperationB();
        _subsystemA.OperationA();
    }

    public void Operation3()
    {
        _subsystemC.OperationC();
        _subsystemA.OperationA();
    }
}
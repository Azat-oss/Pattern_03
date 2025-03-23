

namespace Pattern_03.State;

public class StateB:IState
{
    public void Handle(Context context)
    {
        Console.WriteLine("Обрабатывается состояние B. Переход к состоянию A.");
        context.SetState(new StateA());
    }
}

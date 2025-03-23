

namespace Pattern_03.State;

public class StateA:IState
{
    public void Handle(Context context)
    {
        Console.WriteLine("Обрабатывается состояние A. Переход к состоянию B.");
        context.SetState(new StateB());
    }
}



namespace Pattern_03.State;

public class Context
{
    private IState _state;

    public Context(IState state)
    {
        SetState(state);
    }

    public void SetState(IState state)
    {
        _state = state;
    }

    public void Request()
    {
        _state.Handle(this);
    }
}

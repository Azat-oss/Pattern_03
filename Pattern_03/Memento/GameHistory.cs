

namespace Pattern_03.Memento;

public class GameHistory
{
    private Stack<HeroMemento> history;

    public GameHistory()
    {
        history = new Stack<HeroMemento>();
    }

    public void Add(HeroMemento heroMemento)
    {
        history.Push(heroMemento);
    }

    public HeroMemento Pop()
    {
        var heroMemento = history.Pop();

        return heroMemento;
    }
}

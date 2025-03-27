

namespace Pattern_03.Memento;

public class HeroMemento
{
    public int Lives { get; set; }
    public int Ammunition { get; set; }

    public HeroMemento(int lives, int ammunition)
    {
        Lives = lives;
        Ammunition = ammunition;
    }
}

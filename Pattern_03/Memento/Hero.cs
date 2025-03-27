

namespace Pattern_03.Memento;

public class Hero
{
    private int _lives;
    private int _ammunition;

    public Hero(int lives, int ammunition)
    {
        _lives = lives;
        _ammunition = ammunition;
    }

    public void Shoot()
    {
        _ammunition--;

        Console.WriteLine($"кол-во патрон {_ammunition}");
    }

    public HeroMemento SaveState()
    {
        return new HeroMemento(_lives, _ammunition);
    }

    public void RestoreState(HeroMemento heroMemento)
    {
        _lives = heroMemento.Lives;
        _ammunition = heroMemento.Ammunition;
    }
}

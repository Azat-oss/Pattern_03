

namespace Pattern_03.Flyweight;

public class Character : ICharacter
{
    private readonly char _symbol;
    private readonly string _font;

    public Character(char symbol, string font)
    {
        _symbol = symbol;
        _font = font;
    }

    public void Display(int fontSize)
    {
        Console.WriteLine($"Character: {_symbol}, Font: {_font}, Font Size: {fontSize}");
    }
}

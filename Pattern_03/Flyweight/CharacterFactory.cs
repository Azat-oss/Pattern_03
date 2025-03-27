

namespace Pattern_03.Flyweight;

public class CharacterFactory
{
    private readonly Dictionary<char, ICharacter> _characters = new();

    public ICharacter GetCharacter(char symbol, string font)
    {
        // Проверяем, существует ли уже символ в нашей фабрике
        if (!_characters.ContainsKey(symbol))
        {
            _characters[symbol] = new Character(symbol, font);
        }
        return _characters[symbol];
    }
}

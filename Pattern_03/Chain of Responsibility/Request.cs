

namespace Pattern_03.Chain_of_Responsibility;

 class Request
{
    public int Level { get; private set; }

    public Request(int level)
    {
        Level = level;
    }
}

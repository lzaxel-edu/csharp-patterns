using FactoryMethod.Abstract;

namespace FactoryMethod.Loft;

public class LoftChair : IChair
{
    public override string ToString()
    {
        return "I'm a loft chair";
    }
}
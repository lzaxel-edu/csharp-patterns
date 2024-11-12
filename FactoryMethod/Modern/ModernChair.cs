using FactoryMethod.Abstract;

namespace FactoryMethod.Modern;

public class ModernChair : IChair
{
    public override string ToString()
    {
        return "I'm a modern chair";
    }
}
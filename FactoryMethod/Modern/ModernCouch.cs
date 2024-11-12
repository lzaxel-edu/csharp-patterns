using FactoryMethod.Abstract;

namespace FactoryMethod.Modern;

public class ModernCouch : ICouch
{
    public override string ToString()
    {
        return "I'm a modern couch";
    }
}
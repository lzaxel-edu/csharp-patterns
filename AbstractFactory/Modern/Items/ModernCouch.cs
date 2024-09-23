using AbstractFactory.Abstract.Items;

namespace AbstractFactory.Modern.Items;

public class ModernCouch : ICouch
{
    public override string ToString()
    {
        return "I'm a modern couch";
    }
}
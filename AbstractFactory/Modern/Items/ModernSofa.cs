using AbstractFactory.Abstract.Items;

namespace AbstractFactory.Modern.Items;

public class ModernSofa : ISofa
{
    public override string ToString()
    {
        return "I'm a modern sofa";
    }
}
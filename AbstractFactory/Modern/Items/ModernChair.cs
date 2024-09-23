using AbstractFactory.Abstract.Items;

namespace AbstractFactory.Modern.Items;

public class ModernChair : IChair
{
    public override string ToString()
    {
        return "I'm a modern chair";
    }
}
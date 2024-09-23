using AbstractFactory.Abstract.Items;

namespace AbstractFactory.Modern.Items;

public class ModernBench : IBench
{
    public override string ToString()
    {
        return "I'm a modern bench";
    }
}
using AbstractFactory.Abstract.Items;

namespace AbstractFactory.Loft.Items;

public class LoftChair : IChair
{
    public override string ToString()
    {
        return "I'm a loft chair";
    }
}
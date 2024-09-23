using AbstractFactory.Abstract.Items;

namespace AbstractFactory.Hitech.Items;

public class HitechChair : IChair
{
    public override string ToString()
    {
        return "I'm a hitech chair";
    }
}
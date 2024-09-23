using AbstractFactory.Abstract.Items;

namespace AbstractFactory.Hitech.Items;

public class HitechCouch : ICouch
{
    public override string ToString()
    {
        return "I'm a hitech couch";
    }
}
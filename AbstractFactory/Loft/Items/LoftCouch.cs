using AbstractFactory.Abstract.Items;

namespace AbstractFactory.Loft.Items;

public class LoftCouch : ICouch
{
    public override string ToString()
    {
        return "I'm a loft couch";
    }
}
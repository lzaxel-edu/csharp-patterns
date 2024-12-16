using Decorator.Coffee;

namespace Decorator.Additions;

public abstract class WithAdditions: ICoffee
{
    protected ICoffee _coffee;

    protected WithAdditions(ICoffee coffee)
    {
        if (coffee == null) throw new ArgumentNullException(nameof(coffee));
        _coffee = coffee;
    }
    protected abstract decimal DoCost();
    protected abstract string DoName();
    public decimal Cost()
    {
        return _coffee.Cost() + DoCost();
    }

    public string Name()
    {
        return _coffee.Name() + DoName();
    }
}
using Decorator.Coffee;

namespace Decorator.Additions;

public class WithDiscount:WithAdditions
{
    public WithDiscount(ICoffee coffee) : base(coffee) {}
    public override decimal DoCost() => _coffee.Cost() * -0.1m;
}
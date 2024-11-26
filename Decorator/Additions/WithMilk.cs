using Decorator.Coffee;

namespace Decorator.Additions;

public class WithMilk: WithAdditions
{
    public WithMilk(ICoffee coffee) : base(coffee) {}
    protected override decimal DoCost() => 5;
}
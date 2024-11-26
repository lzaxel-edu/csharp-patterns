using Decorator.Coffee;

namespace Decorator.Additions;

public class WithMilk: WithAdditions
{
    public WithMilk(ICoffee coffee) : base(coffee) {}
    public override decimal DoCost() => 5;
}
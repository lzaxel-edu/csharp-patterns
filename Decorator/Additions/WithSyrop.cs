using Decorator.Coffee;

namespace Decorator.Additions;

public class WithSyrup: WithAdditions
{
    public WithSyrup(ICoffee coffee) : base(coffee) {}
    protected override decimal DoCost() => 3;
}
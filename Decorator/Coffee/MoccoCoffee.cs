namespace Decorator.Coffee;

public class MoccoCoffee: ICoffee
{
    public decimal Cost() => 25;
    public string Name() => "Mocco";
}
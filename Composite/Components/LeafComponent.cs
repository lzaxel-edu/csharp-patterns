namespace Composite.Components;

public class LeafComponent: IComponent
{
    private double _value;

    public LeafComponent(double value)
    {
        _value = value;
    }
    public double GetSum() => _value;
    public IEnumerable<double> GetValue()
    {
        yield return _value;
    }
}
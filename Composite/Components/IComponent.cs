namespace Composite.Components;

public interface IComponent
{
    public IEnumerable<double> GetValue();
    public double GetSum();
}
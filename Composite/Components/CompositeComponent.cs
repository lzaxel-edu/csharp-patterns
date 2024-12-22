namespace Composite.Components;

public class CompositeComponent : IComponent
{
    public CompositeComponent() {}

    public CompositeComponent(IEnumerable<IComponent> components)
    {
        _components = new List<IComponent>(components);
    }
    
    private List<IComponent> _components = new List<IComponent>();

    public void Add(IComponent component)
    {
        _components.Add(component);
    }

    public IEnumerable<double> GetValue()
    {
        foreach (var component in _components)
        {
            foreach (var value in component.GetValue())
            {
                yield return value;
            }
        }
    }
    public double GetSum()
    {
        double sum = 0;
        foreach (var component in _components)
        foreach (var value in component.GetValue())
        {
            sum += value;
        }

        return sum;
    }
}
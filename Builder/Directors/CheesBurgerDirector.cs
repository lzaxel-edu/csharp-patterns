namespace Builder;

public class CheeseBurgerDirector
{
    private IBurgerBuilder _builder;
    
    public CheeseBurgerDirector(IBurgerBuilder builder)
    {
        _builder = builder;
    }

    public void Build()
    {
        _builder.WithCheese();
    }
}
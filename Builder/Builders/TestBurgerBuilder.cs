namespace Builder;

public class TestBurgerBuilder : IBurgerBuilder
{
    private readonly List<string> _ingredients;

    public TestBurgerBuilder()
    {
        _ingredients = new List<string>();
    }

    public void WithCheese()
    {
        _ingredients.Add("Cheese");
    }

    public void WithBecon()
    {
        _ingredients.Add("Becon");
    }

    public void WithTomato()
    {
        _ingredients.Add("Tomato");
    }

    public void WithBeef()
    {
        _ingredients.Add("Beef");
    }

    public bool Build()
    {
        return _ingredients.Contains("Beef");
    }
}
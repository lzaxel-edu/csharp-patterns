namespace Builder;

public class StringBurgerBuilder : IBurgerBuilder
{
    private readonly List<string> _ingredients;

    public StringBurgerBuilder()
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

    public string Build()
    {
        return string.Join(" ", _ingredients);
    }
}
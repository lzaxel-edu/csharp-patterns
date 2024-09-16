using System.Text;

namespace Builder;

public class Burger
{
    public Burger(List<string> ingredients)
    {
        Ingredients = ingredients;
    }

    public List<string> Ingredients { get; set; }

    public override string ToString()
    {
        var text = new StringBuilder();
        text.Append("Burger: ");
        text.Append("Ingredients: ");
        text.AppendJoin(", ", Ingredients);
        
        return text.ToString();
    }
}
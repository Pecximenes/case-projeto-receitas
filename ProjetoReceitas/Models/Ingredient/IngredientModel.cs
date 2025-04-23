namespace Ingredient.Models;

public class IngredientModel
{
    public IngredientModel(string name)
    {
        Name = name;
        Id = Guid.NewGuid();
    }


    public Guid Id { get; init; }
    public string Name {get; private set; }
    
}
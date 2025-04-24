using RecipeIngredient.Models;

namespace Recipe.Models;

public class RecipeModel
{
    public RecipeModel() // Necessário para o EF
    {
        Ingredients = new List<RecipeIngredientModel>();
        Id = Guid.NewGuid();
    }

    public RecipeModel(string name, string preparationMethod, List<RecipeIngredientModel> ingredients)
    {
        Id = Guid.NewGuid();
        Name = name;
        PreparationMethod = preparationMethod;
        Ingredients = ingredients;
    }

    public Guid Id { get; set; }
    public string Name { get; private set; }
    public string PreparationMethod { get; private set; }
    public List<RecipeIngredientModel> Ingredients { get; private set; }


    public void ChangeName(string name)
    {
        Name = name;
    }
    public void ChangePreparationMethod(string preparationMethod)
    {
        PreparationMethod = preparationMethod;
    }
    public void ChangeIngredients(List<RecipeIngredientModel> ingredients)
    {
        Ingredients = ingredients;
    }
}

public record RecipeRequest(string name, string preparationMethod, List<RecipeIngredientModel> ingredients);

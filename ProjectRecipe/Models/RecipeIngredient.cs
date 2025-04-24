using Ingredient.Models;
using Recipe.Models;

namespace RecipeIngredient.Models;

public class RecipeIngredientModel
{
    public RecipeIngredientModel(int quantity, List<RecipeModel> recipeList, List<IngredientModel> ingredientList)
    {
        Id = Guid.NewGuid();
        Quantity = quantity;
        RecipeList = recipeList;
        IngredientList = ingredientList;
    }

    public Guid Id { get; set; }
    public int Quantity { get; private set; }
    public List<RecipeModel> RecipeList { get; set; }
    public List<IngredientModel> IngredientList { get; set; }

    public void ChangeQuantity(int quantity)
    {
        Quantity = quantity;
    }
}

public record RecipeIngredientRequest(int quantity, List<RecipeModel> recipeList, List<IngredientModel> ingredientList);

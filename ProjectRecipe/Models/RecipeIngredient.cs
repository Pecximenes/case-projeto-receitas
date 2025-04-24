using Ingredient.Models;
using Recipe.Models;

namespace RecipeIngredient.Models;

public class RecipeIngredientModel
{
//     public RecipeIngredientModel(int quantity, List<RecipeModel> recipeList, List<IngredientModel> ingredientList)
//     {
//         Id = Guid.NewGuid();
//         Quantity = quantity;
//         RecipeList = recipeList;
//         IngredientList = ingredientList;
//     }

//     public RecipeIngredientModel() {}

//     public Guid Id { get; set; }
//     public int Quantity { get; private set; }
//     public List<RecipeModel> RecipeList { get; set; }
//     public List<IngredientModel> IngredientList { get; set; }

//     public void ChangeQuantity(int quantity)
//     {
//         Quantity = quantity;
//     }

    public RecipeIngredientModel()
    {
        Id = Guid.NewGuid();
    }
    public RecipeIngredientModel(IngredientModel ingredient, int quantity)
    {
        Id = Guid.NewGuid();
        Ingredient = ingredient;
        Quantity = quantity;
    }

    public Guid Id { get; set; }
    public IngredientModel Ingredient { get; set; }
    public int Quantity { get; set; }
}

public record RecipeIngredientRequest(IngredientModel ingredient, int quantity);
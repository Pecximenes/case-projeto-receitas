using Ingredient.Models;

namespace Ingredient.Routes;

public static class IngredientRoute
{
    public static void IngredientRoutes(this WebApplication app)
    {
        app.MapGet("ProjetoReceitas", () => new IngredientModel("Farinha"));
    }
}
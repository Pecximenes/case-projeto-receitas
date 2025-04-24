using Microsoft.EntityFrameworkCore;
using ProjectRecipesss.Data;
using RecipeIngredient.Models;

namespace RecipeIngredient.Routes;

public static class RecipeIngredientRoute
{
    public static void RecipeIngredientRoutes(this WebApplication app)
    {   
        var route = app.MapGroup("Recipes");
        // app.MapGet("ProjectRecipe", () => new ProjectRecipeModel("farinha"));
        route.MapPost("",
            async (RecipeIngredientRequest req, ProjectContext context) =>
            {
                var recipe = new RecipeIngredientModel(req.ingredient, req.quantity);
                await context.AddAsync(recipe);
                await context.SaveChangesAsync(); //Commit para o Banco de Dados
            });
        
        route.MapGet("",
            async (ProjectContext context) => 
            {
                var recipeList = await context.Recipe.ToListAsync();
                return Results.Ok(recipeList);
            });
        
        // route.MapPut("{id:guid}",
        //     async (Guid id, RecipeRequest req, ProjectContext context) => 
        //     {
        //         var recipe = await context.Recipe.FirstOrDefaultAsync(x => x.Id == id);

        //         if (recipe == null)
        //             return Results.NotFound();
                
        //         recipe.ChangeName(req.name);
        //         recipe.ChangePreparationMethod(req.preparationMethod);
        //         recipe.ChangeIngredients(req.ingredients);
        //         await context.SaveChangesAsync();
        //         return Results.Ok(recipe);
        //     });
        
        // route.MapDelete("{id:guid}",
        //     async (Guid id, ProjectContext context) =>
        //     {
        //         var recipe = await context.Recipe.FirstOrDefaultAsync(x => x.Id == id);

        //         if (recipe == null)
        //             return Results.NotFound($"Ingrediente com ID {id} não encontrado.");
                
        //         // recipe.SetInactive();
        //         context.Recipe.Remove(recipe);
        //         await context.SaveChangesAsync();
        //         return Results.Ok(recipe);
        //     });
            
    }
}

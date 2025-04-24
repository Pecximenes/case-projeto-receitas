using Microsoft.EntityFrameworkCore;
using ProjectRecipesss.Data;
using Ingredient.Models;

namespace Ingredient.Routes;

public static class IngredientRoute
{
    public static void IngredientRoutes(this WebApplication app)
    {   
        var route = app.MapGroup("Ingredients");
        // app.MapGet("ProjectRecipe", () => new ProjectRecipeModel("farinha"));
        route.MapPost("",
            async (IngredientRequest req, ProjectContext context) =>
            {
                var ingredientName = new IngredientModel(req.name, req.unitOfMeasurement);
                await context.AddAsync(ingredientName);
                await context.SaveChangesAsync(); //Commit para o Banco de Dados
            });
        
        route.MapGet("",
            async (ProjectContext context) => 
            {
                var ingredientList = await context.Ingredient.ToListAsync();
                return Results.Ok(ingredientList);
            });
        
        route.MapPut("{id:guid}",
            async (Guid id, IngredientRequest req, ProjectContext context) => 
            {
                var ingredient = await context.Ingredient.FirstOrDefaultAsync(x => x.Id == id);

                if (ingredient == null)
                    return Results.NotFound();
                
                ingredient.ChangeName(req.name);
                ingredient.ChangeUnitOfMeasurement(req.unitOfMeasurement);
                await context.SaveChangesAsync();
                return Results.Ok(ingredient);
            });
        
        route.MapDelete("{id:guid}",
            async (Guid id, ProjectContext context) =>
            {
                var ingredient = await context.Ingredient.FirstOrDefaultAsync(x => x.Id == id);

                if (ingredient == null)
                    return Results.NotFound($"Ingrediente com ID {id} não encontrado.");
                
                // ingredient.SetInactive();
                context.Ingredient.Remove(ingredient);
                await context.SaveChangesAsync();
                return Results.Ok(ingredient);
            });
            
    }
}

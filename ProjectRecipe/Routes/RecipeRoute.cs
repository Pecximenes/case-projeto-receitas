using Microsoft.EntityFrameworkCore;
using ProjectRecipesss.Data;
using Recipe.Models;

namespace Recipe.Routes;

public static class ProjectRecipeRoute
{
    public static void RecipeRoutes(this WebApplication app)
    {   
        var route = app.MapGroup("Recipes");
        // app.MapGet("ProjectRecipe", () => new ProjectRecipeModel("farinha"));
        route.MapPost("",
            async (RecipeRequest req, ProjectContext context) =>
            {
                var ingredientName = new RecipeModel(req.name);
                await context.AddAsync(ingredientName);
                await context.SaveChangesAsync(); //Commit para o Banco de Dados
            });
        
        route.MapGet("",
            async (ProjectContext context) => 
            {
                var ingredientList = await context.Recipe.ToListAsync();
                return Results.Ok(ingredientList);
            });
        
        route.MapPut("{id:guid}",
            async (Guid id, RecipeRequest req, ProjectContext context) => 
            {
                var ingredient = await context.Recipe.FirstOrDefaultAsync(x => x.Id == id);

                if (ingredient == null)
                    return Results.NotFound();
                
                ingredient.ChangeName(req.name);
                await context.SaveChangesAsync();
                return Results.Ok(ingredient);
            });
        
        route.MapDelete("{id:guid}",
            async (Guid id, ProjectContext context) =>
            {
                var ingredient = await context.Recipe.FirstOrDefaultAsync(x => x.Id == id);

                if (ingredient == null)
                    return Results.NotFound($"Ingrediente com ID {id} não encontrado.");
                
                // ingredient.SetInactive();
                context.Recipe.Remove(ingredient);
                await context.SaveChangesAsync();
                return Results.Ok(ingredient);
            });
            
    }
}

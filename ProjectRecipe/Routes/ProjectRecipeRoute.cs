using Microsoft.EntityFrameworkCore;
using ProjectRecipe.Data;
using ProjectRecipe.Models;

namespace ProjectRecipe.Routes;

public static class ProjectRecipeRoute
{
    public static void ProjectRecipeRoutes(this WebApplication app)
    {   
        var route = app.MapGroup("ProjectRecipe");
        // app.MapGet("ProjectRecipe", () => new ProjectRecipeModel("farinha"));
        route.MapPost("",
            async (ProjectRecipeRequest req, ProjectRecipeContext context) =>
            {
                var ingredientName = new ProjectRecipeModel(req.name);
                await context.AddAsync(ingredientName);
                await context.SaveChangesAsync(); //Commit para o Banco de Dados
            });
        
        route.MapGet("",
            async (ProjectRecipeContext context) => 
            {
                var ingredientList = await context.Ingredient.ToListAsync();
                return Results.Ok(ingredientList);
            });
        
        route.MapPut("{id:guid}",
            async (Guid id, ProjectRecipeRequest req, ProjectRecipeContext context) => 
            {
                var ingredient = await context.Ingredient.FirstOrDefaultAsync(x => x.Id == id);

                if (ingredient == null)
                    return Results.NotFound();
                
                ingredient.ChangeName(req.name);
                await context.SaveChangesAsync();
                return Results.Ok(ingredient);
            });
        
        route.MapDelete("{id:guid}",
            async (Guid id, ProjectRecipeContext context) =>
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

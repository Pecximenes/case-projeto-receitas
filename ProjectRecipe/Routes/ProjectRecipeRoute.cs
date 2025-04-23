using ProjectRecipe.Models;

namespace ProjectRecipe.Routes;

public static class ProjectRecipeRoute
{
    public static void ProjectRecipeRoutes(this WebApplication app)
    {
        app.MapGet("ProjectRecipe", () => new ProjectRecipeModel("farinha"));
    }
}

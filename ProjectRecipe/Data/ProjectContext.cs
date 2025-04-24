using Microsoft.EntityFrameworkCore;
using Ingredient.Models;
using Recipe.Models;

namespace ProjectRecipesss.Data;

public class ProjectContext : DbContext
{
    public DbSet<IngredientModel> Ingredient { get; set; }
    public DbSet<RecipeModel> Recipe { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=projectRecipe.sqlite");
        base.OnConfiguring(optionsBuilder);
    }
}
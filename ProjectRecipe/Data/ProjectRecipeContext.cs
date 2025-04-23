using Microsoft.EntityFrameworkCore;
using ProjectRecipe.Models;

namespace ProjectRecipe.Data;

public class ProjectRecipeContext : DbContext
{
    public DbSet<ProjectRecipeModel> Ingredient { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=projectRecipe.sqlite");
        base.OnConfiguring(optionsBuilder);
    }
}
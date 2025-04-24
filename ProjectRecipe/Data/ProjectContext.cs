using Microsoft.EntityFrameworkCore;
using Ingredient.Models;
using Recipe.Models;
using RecipeIngredient.Models;

namespace ProjectRecipesss.Data;

public class ProjectContext : DbContext
{
    public DbSet<IngredientModel> Ingredient { get; set; }
    public DbSet<RecipeModel> Recipe { get; set; }
    public DbSet<RecipeIngredientModel> RecipeIngredient { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=projectRecipe.sqlite");
        base.OnConfiguring(optionsBuilder);
    }
}



// public class ProjectContext : DbContext
// {
//     public DbSet<RecipeModel> Recipe { get; set; }
//     public DbSet<IngredientModel> Ingredient { get; set; }
//     // public DbSet<ReceipeIngredientModel> RecipeIngredient { get; set; }

//     // public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

//     protected override void OnModelCreating(ModelBuilder modelBuilder)
//     {
//         // modelBuilder.Entity<ReceitaIngrediente>()
//         //     .HasOne(ri => ri.Receita)
//         //     .WithMany(r => r.ReceitaIngredientes)
//         //     .HasForeignKey(ri => ri.ReceitaId)
//         //     .OnDelete(DeleteBehavior.Cascade);

//         // modelBuilder.Entity<ReceitaIngrediente>()
//         //     .HasOne(ri => ri.Ingrediente)
//         //     .WithMany(i => i.ReceitaIngredientes)
//         //     .HasForeignKey(ri => ri.IngredienteId)
//         //     .OnDelete(DeleteBehavior.Cascade);
//     }
// }
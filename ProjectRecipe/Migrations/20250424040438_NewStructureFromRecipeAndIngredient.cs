using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectRecipe.Migrations
{
    /// <inheritdoc />
    public partial class NewStructureFromRecipeAndIngredient : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PreparationMethod",
                table: "Recipe",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UnitOfMeasurement",
                table: "Ingredient",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PreparationMethod",
                table: "Recipe");

            migrationBuilder.DropColumn(
                name: "UnitOfMeasurement",
                table: "Ingredient");
        }
    }
}

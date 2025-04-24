using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectRecipe.Migrations
{
    /// <inheritdoc />
    public partial class CreateTableRecipeIngredient : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Recipe",
                table: "Recipe");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ingredient",
                table: "Ingredient");

            migrationBuilder.RenameTable(
                name: "Recipe",
                newName: "Recipes");

            migrationBuilder.RenameTable(
                name: "Ingredient",
                newName: "Ingredients");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Recipes",
                table: "Recipes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ingredients",
                table: "Ingredients",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "RecipeIngredientModel",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    IngredientId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false),
                    RecipeModelId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipeIngredientModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RecipeIngredientModel_Ingredients_IngredientId",
                        column: x => x.IngredientId,
                        principalTable: "Ingredients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RecipeIngredientModel_Recipes_RecipeModelId",
                        column: x => x.RecipeModelId,
                        principalTable: "Recipes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_RecipeIngredientModel_IngredientId",
                table: "RecipeIngredientModel",
                column: "IngredientId");

            migrationBuilder.CreateIndex(
                name: "IX_RecipeIngredientModel_RecipeModelId",
                table: "RecipeIngredientModel",
                column: "RecipeModelId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RecipeIngredientModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Recipes",
                table: "Recipes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ingredients",
                table: "Ingredients");

            migrationBuilder.RenameTable(
                name: "Recipes",
                newName: "Recipe");

            migrationBuilder.RenameTable(
                name: "Ingredients",
                newName: "Ingredient");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Recipe",
                table: "Recipe",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ingredient",
                table: "Ingredient",
                column: "Id");
        }
    }
}

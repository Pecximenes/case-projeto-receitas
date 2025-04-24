using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectRecipe.Migrations
{
    /// <inheritdoc />
    public partial class CreateTableRecipeIngredientv2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RecipeIngredientModel_Ingredients_IngredientId",
                table: "RecipeIngredientModel");

            migrationBuilder.DropForeignKey(
                name: "FK_RecipeIngredientModel_Recipes_RecipeModelId",
                table: "RecipeIngredientModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Recipes",
                table: "Recipes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RecipeIngredientModel",
                table: "RecipeIngredientModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ingredients",
                table: "Ingredients");

            migrationBuilder.RenameTable(
                name: "Recipes",
                newName: "Recipe");

            migrationBuilder.RenameTable(
                name: "RecipeIngredientModel",
                newName: "RecipeIngredient");

            migrationBuilder.RenameTable(
                name: "Ingredients",
                newName: "Ingredient");

            migrationBuilder.RenameIndex(
                name: "IX_RecipeIngredientModel_RecipeModelId",
                table: "RecipeIngredient",
                newName: "IX_RecipeIngredient_RecipeModelId");

            migrationBuilder.RenameIndex(
                name: "IX_RecipeIngredientModel_IngredientId",
                table: "RecipeIngredient",
                newName: "IX_RecipeIngredient_IngredientId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Recipe",
                table: "Recipe",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RecipeIngredient",
                table: "RecipeIngredient",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ingredient",
                table: "Ingredient",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RecipeIngredient_Ingredient_IngredientId",
                table: "RecipeIngredient",
                column: "IngredientId",
                principalTable: "Ingredient",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RecipeIngredient_Recipe_RecipeModelId",
                table: "RecipeIngredient",
                column: "RecipeModelId",
                principalTable: "Recipe",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RecipeIngredient_Ingredient_IngredientId",
                table: "RecipeIngredient");

            migrationBuilder.DropForeignKey(
                name: "FK_RecipeIngredient_Recipe_RecipeModelId",
                table: "RecipeIngredient");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RecipeIngredient",
                table: "RecipeIngredient");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Recipe",
                table: "Recipe");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ingredient",
                table: "Ingredient");

            migrationBuilder.RenameTable(
                name: "RecipeIngredient",
                newName: "RecipeIngredientModel");

            migrationBuilder.RenameTable(
                name: "Recipe",
                newName: "Recipes");

            migrationBuilder.RenameTable(
                name: "Ingredient",
                newName: "Ingredients");

            migrationBuilder.RenameIndex(
                name: "IX_RecipeIngredient_RecipeModelId",
                table: "RecipeIngredientModel",
                newName: "IX_RecipeIngredientModel_RecipeModelId");

            migrationBuilder.RenameIndex(
                name: "IX_RecipeIngredient_IngredientId",
                table: "RecipeIngredientModel",
                newName: "IX_RecipeIngredientModel_IngredientId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RecipeIngredientModel",
                table: "RecipeIngredientModel",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Recipes",
                table: "Recipes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ingredients",
                table: "Ingredients",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RecipeIngredientModel_Ingredients_IngredientId",
                table: "RecipeIngredientModel",
                column: "IngredientId",
                principalTable: "Ingredients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RecipeIngredientModel_Recipes_RecipeModelId",
                table: "RecipeIngredientModel",
                column: "RecipeModelId",
                principalTable: "Recipes",
                principalColumn: "Id");
        }
    }
}

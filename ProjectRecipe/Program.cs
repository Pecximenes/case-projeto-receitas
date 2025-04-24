using ProjectRecipesss.Data;
using Ingredient.Routes;
using Recipe.Routes;
using RecipeIngredient.Routes;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ProjectContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.IngredientRoutes();
app.RecipeRoutes();
// app.RecipeIngredientRoutes();

app.UseHttpsRedirection();
app.Run();

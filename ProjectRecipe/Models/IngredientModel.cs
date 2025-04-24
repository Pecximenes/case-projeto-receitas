namespace Ingredient.Models;

public class IngredientModel
{
    public IngredientModel(string name, string unitOfMeasurement)
    {
        Id = Guid.NewGuid();
        Name = name;
        UnitOfMeasurement = unitOfMeasurement;
    }

    public Guid Id { get; set; }
    public string Name { get; private set; }
    public string UnitOfMeasurement { get; private set; }

    public void ChangeName(string name)
    {
        Name = name;
    }

    public void ChangeUnitOfMeasurement(string unitOfMeasurement)
    {
        UnitOfMeasurement = unitOfMeasurement;
    }
}

public record IngredientRequest(string name, string unitOfMeasurement);

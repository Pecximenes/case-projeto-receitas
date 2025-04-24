namespace Recipe.Models;

public class RecipeModel
{
    public RecipeModel(string name, string preparationMethod)
    {
        Id = Guid.NewGuid();
        Name = name;
        PreparationMethod = preparationMethod;
    }

    public Guid Id { get; set; }
    public string Name { get; private set; }
    public string PreparationMethod { get; private set; }

    public void ChangeName(string name)
    {
        Name = name;
    }
    public void ChangePreparationMethod(string preparationMethod)
    {
        PreparationMethod = preparationMethod;
    }
}

public record RecipeRequest(string name, string preparationMethod);

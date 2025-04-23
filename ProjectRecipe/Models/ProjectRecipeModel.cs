namespace ProjectRecipe.Models;

public class ProjectRecipeModel
{
    public ProjectRecipeModel(string name)
    {
        Name = name;
        Id = Guid.NewGuid();
    }

    public Guid Id { get; set; }
    public string Name { get; private set; }

    public void ChangeName(string name)
    {
        Name = name;
    }

    public void SetInactive()
    {
        Name = "desativado";
    }


}
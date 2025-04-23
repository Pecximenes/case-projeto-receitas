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


}
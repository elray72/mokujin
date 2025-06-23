namespace Data.Food.Models;

public class RecipeStep
{
    public Guid Id { get; set; }
    public Guid RecipeId { get; set; }
    public int Order { get; set; }
    public string Instruction { get; set; } = string.Empty;

    // Foreign key to Recipe
    public Recipe Recipe { get; set; }
}
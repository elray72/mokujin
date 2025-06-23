namespace Data.Food.Models;

public class Recipe
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public decimal? Weight { get; set; }
    public decimal? Serves { get; set; }
    public TimeSpan? PreparationTime { get; set; }
    public TimeSpan? CookingTime { get; set; }

    public virtual ICollection<Recipe> Components { get; set; }
    public virtual ICollection<Ingredient> Ingredients { get; set; }
    public virtual ICollection<RecipeStep> Steps { get; set; } = [];
}
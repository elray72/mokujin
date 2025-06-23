namespace Data.Food.Models;

public class FoodUnit
{
    public int Id { get; set; }
    public string Value { get; set; } // "g", "kg", "ml"

    // Navigation properties
    public ICollection<Food> Food { get; set; } = new List<Food>();
}
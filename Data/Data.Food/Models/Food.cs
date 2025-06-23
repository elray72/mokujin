namespace Data.Food.Models;

public class Food
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string? Brand { get; set; } // optional
    public string? Description { get; set; } // optional

    // Serving information
    public string ServingWeight { get; set; } // eg. "100"
    public int ServingUnitId { get; set; } // eg. "g"
    public decimal ServingSize { get; set; } // eg. 1
    public string ServingName { get; set; } // eg. "piece", "cup", "slice"

    // Nutritional information
    public decimal? Calories { get; set; }
    public decimal? Protein { get; set; }
    public decimal? Fat { get; set; }
    public decimal? SaturatedFat { get; set; }
    public decimal? Carbohydrates { get; set; }
    public decimal? Sugars { get; set; }
    public decimal? Fibre { get; set; }
    public decimal? Sodium { get; set; }

    // Navigation properties
    public virtual FoodUnit ServingUnit { get; set; }
}
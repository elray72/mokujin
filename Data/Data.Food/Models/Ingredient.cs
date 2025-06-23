namespace Data.Food.Models;

public class Ingredient
{
    public Guid Id { get; set; }
    public Guid FoodId { get; set; }
    public decimal Quantity { get; set; }
    public int QuantityUnitId { get; set; }

    public virtual Food Food { get; set; }
    public virtual FoodUnit QuantityUnit { get; set; }
}
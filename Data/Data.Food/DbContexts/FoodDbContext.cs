using Data.Food.Models;
using Microsoft.EntityFrameworkCore;

namespace Data.Food.DbContexts;

public class FoodDbContext(DbContextOptions<FoodDbContext> options)
    : DbContext(options)
{
    public DbSet<Models.Food> Food { get; set; }
    public DbSet<FoodUnit> FoodUnits { get; set; }
    public DbSet<Ingredient> Ingredients { get; set; }
    public DbSet<Recipe> Recipes { get; set; }
    public DbSet<RecipeStep> RecipeSteps { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Food -> FoodUnit (serving unit)
        modelBuilder.Entity<Models.Food>()
            .HasOne(f => f.ServingUnit)
            .WithMany(u => u.Food)
            .HasForeignKey(f => f.ServingUnitId);

        // Ingredient -> Food
        modelBuilder.Entity<Ingredient>()
            .HasOne(i => i.Food)
            .WithMany()
            .HasForeignKey(i => i.FoodId);

        // Ingredient -> FoodUnit
        modelBuilder.Entity<Ingredient>()
            .HasOne(i => i.QuantityUnit)
            .WithMany()
            .HasForeignKey(i => i.QuantityUnitId);

        // Recipe -> Components (self-referencing many-to-many)
        modelBuilder.Entity<Recipe>()
            .HasMany(r => r.Components)
            .WithMany();

        // RecipeStep -> Recipe
        modelBuilder.Entity<RecipeStep>()
            .HasOne(rs => rs.Recipe)
            .WithMany(r => r.Steps)
            .HasForeignKey(rs => rs.RecipeId);
    }
}
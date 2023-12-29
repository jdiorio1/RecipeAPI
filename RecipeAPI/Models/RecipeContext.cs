using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace RecipeAPI.Models
{
    public class RecipeContext : DbContext
    {
        public RecipeContext(DbContextOptions<RecipeContext> options)
            : base(options)
        {
        }
        public DbSet<Recipe> Recipes { get; set; } = null!;
        public DbSet<Instruction> Instructions { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Recipe_Ingredient> Recipe_Ingredients { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Recipe_Ingredient>().HasKey(ri => new { ri.RecipeId, ri.IngredientId });
        }
    }
}

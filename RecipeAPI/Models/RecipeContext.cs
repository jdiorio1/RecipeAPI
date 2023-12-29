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
        public DbSet<Direction> Directions { get; set; }
        public DbSet<Ingredient> Ingredient { get; set; }
        public DbSet<Recipe_Ingredient> Recipe_Ingredients{get; set;}
    }
}

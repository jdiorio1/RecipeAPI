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
    }
}

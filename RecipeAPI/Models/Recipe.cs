namespace RecipeAPI.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public DateTime DateAdded { get; set; }
        public string? Source { get; set; }
        public string? Name { get; set; }
        public ICollection<Direction> Directions { get; set; }
        public ICollection<Recipe_Ingredient> Recipe_Ingredients { get; set; }
    }
}

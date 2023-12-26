namespace RecipeAPI.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public List<string>? Directions { get; set; }
        public List<string>? Ingredients { get; set; }
        public DateOnly DateAdded { get; set; }
        public string? Source { get; set; }
    }
}

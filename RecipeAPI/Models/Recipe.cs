namespace RecipeAPI.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public Dictionary<int,string>? Directions { get; set; }
        public List<string>? Ingredients { get; set; }
        public DateTime DateAdded { get; set; }
        public string? Source { get; set; }
    }
}

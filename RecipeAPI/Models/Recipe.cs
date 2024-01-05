namespace RecipeAPI.Models
{
    public class Recipe
    {
        public int RecipeId { get; set; }
        public DateTime? DateAdded { get; set; }
        public string? Source { get; set; }
        public string Name { get; set; }
        public ICollection<Instruction>? Instructions { get; set; }
        public ICollection<Recipe_Ingredient>? RecipeIngredients { get; set; }
    }
}

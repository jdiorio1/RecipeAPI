namespace RecipeAPI.Models
{
    public class Ingredient
    {
        public int IngredientId { get; set; }
        public string IngredientName { get; set; }
        public ICollection<Recipe_Ingredient> Recipe_Ingredients { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecipeAPI.Models
{
    public class Recipe_Ingredient
    {
        [Key,Column(Order=0)]
        public int RecipeId { get; set; }
        [Key,Column(Order=1)]
        public int IngredientId { get; set; }
    }
}

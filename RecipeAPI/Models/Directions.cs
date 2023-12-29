namespace RecipeAPI.Models
{
    public class Direction
    {
        public int Id { get; set; }
        public Dictionary<int, string> Directions { get; set; }
        public int RecipeId { get; set; }
    }
}

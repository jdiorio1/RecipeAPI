namespace RecipeAPI.Models
{
    public class Instructions
    {
        public int InstructionsId { get; set; }
        public Dictionary<int, string> Steps { get; set; }
        public int RecipeId { get; set; }
    }
}

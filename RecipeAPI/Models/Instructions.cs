namespace RecipeAPI.Models
{
    public class Instructions
    {
        public int InstructionsID { get; set; }
        public Dictionary<int, string> Steps { get; set; }
        public int RecipeId { get; set; }
    }
}

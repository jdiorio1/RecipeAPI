namespace RecipeAPI.Models
{
    public class Instructions
    {
        public int InstructionsId { get; set; }
        public int InstructionsNumber { get; set; }
        public string InstructionsDescription { get; set; }
        public int RecipeId { get; set; }
    }
}

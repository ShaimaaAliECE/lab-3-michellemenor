using System;
namespace Lab3App
{
    // Valuable treasure with a score
    public class Diamond : Treasure
    {
        // Constructor that sets the description and score
        public Diamond(string description, int score) : base(description, score)
        {
        }

        // Shows Diamonds description
        public override void Display()
        {
            Console.WriteLine($"Diamond{Description} is displayed");
        }
    }
}

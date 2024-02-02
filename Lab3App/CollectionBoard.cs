using System;
namespace Lab3App
{
    public class CollectionBoard
    {
        // Keeps track of total score of collected items
        public int TotalScore { get; set; }
        // Keeps track of the total value of the collected items
        public int TotalValue { get; set; }

        // Adds the total score and print updated score
        public void UpdateTotalScore(int score)
        {
            TotalScore += score;
            Console.WriteLine($"Total Score is updated to: {TotalScore}");
        }

        // Adds the total value and print updated value
        public void UpdateTotalValue(int value)
        {
            TotalValue += value;
            Console.WriteLine($"Total Value is updated to: {TotalValue}");
        }

    }
}

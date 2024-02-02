using System;
using System.Collections.Generic;

namespace Lab3App
{
    // Subclass of Collectable that respresents valuable items with a score
    public abstract class Treasure : Collectable
    {
        // Holds the point value of the treasure
        public int Score { get; private set; }

        // Constructor sets the description and score of the treasure
        protected Treasure(string description, int score) : base(description)
        {
            Score = score;
        }

        // Override the AddMe method to include behavior for updating the total score
        public override void AddMe(List<Collectable> list)
        {
            // Add the Treasure to the collection list
            list.Add(this);
            Console.WriteLine($"{Description} Collected, Congrats!!!!");

            // Update the total score on the associated board
            Board?.UpdateTotalScore(Score);
        }
    }

}

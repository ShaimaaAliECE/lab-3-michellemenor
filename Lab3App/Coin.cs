using System;
using System.Collections.Generic;

namespace Lab3App
{
    // Type of treasure that has a value in addition to a score
    public class Coin : Treasure
    {
        // Represents the value of the coin
        public int Value { get; set; }

        // Constructor to initialize a new coin with a description, score, and value
        public Coin(string description, int score, int value) : base(description, score)
        {
            Value = value;
        }

        // Display method to output the Coin's description
        public override void Display()
        {
            Console.WriteLine($"Coin {Description} is displayed");
        }

        //Method to update the total value when the coin is added
        public override void AddMe(List<Collectable> list)
        {
            base.AddMe(list); 
            Board.UpdateTotalValue(Value);
        }
    }
}

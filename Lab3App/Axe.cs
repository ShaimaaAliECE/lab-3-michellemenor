using System;
using System.Collections.Generic;

namespace Lab3App
{
    // Type of tool that can be collected
    public class Axe : Tool
    {
        // Constructor that sets the description for the Axe
        public Axe(string description) : base(description)
        {
        }

        // Display method to output the Axe's description when shown
        public override void Display()
        {
            Console.WriteLine($"Axe {Description} is displayed");
        }

        // Method to output what happens when the Axe is used
        public override void DoAction()
        {
            Console.WriteLine("Axe is Used");
        }

        // Method that adds the Axe to a list of collectables and performs the action
        public override void AddMe(List<Collectable> list)
        {
            list.Add(this); // Adds this Axe to the list
            Console.WriteLine($"{Description} Collected, Congrats!!!!");
            DoAction(); //Performs Axe's action
        }

    }
}

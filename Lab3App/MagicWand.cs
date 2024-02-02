using System;
using System.Collections.Generic;

namespace Lab3App
{
    // Tool with unique actions when used 
    public class MagicWand : Tool
    {
        // Constructor that sets description
        public MagicWand(string description) : base(description)
        {
        }

        // Displays the description
        public override void Display()
        {
            Console.WriteLine($"MagicWand {Description} is displayed");
        }

        //Outputs the specific action of the MagicWand when used
        public override void DoAction()
        {
            Console.WriteLine("MagicWand is used");
        }

        // Adds MagicWand to a list
        public override void AddMe(List<Collectable> list)
        {
            list.Add(this); // Adds this MagicWand to the list directly
            Console.WriteLine($"{Description} Collected, Congrats!!!!");
            DoAction();
        }
    }

}

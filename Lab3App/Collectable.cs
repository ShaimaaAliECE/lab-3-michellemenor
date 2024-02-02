using System;
using System.Collections.Generic;

namespace Lab3App
{
    // Base class for objects that can be collected
    public abstract class Collectable : Displayable
    {
        // Description property for the collectable
        public string Description { get; set; }
        // Links the collectable to the collection board
        public CollectionBoard Board { get; set; }

        // Constructor that sets the description
        protected Collectable(string description)
        {
            Description = description;
        }

        // Adds the collectable to a list
        public virtual void AddMe(List<Collectable> list)
        {
            list.Add(this);
            Console.WriteLine($"{Description} Collected, Congrats!!!!");
        }

        // Displays collectable
        public abstract void Display();
    }
}

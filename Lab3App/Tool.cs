using System;
using System.Collections.Generic;

namespace Lab3App
{
    // Subclass of Collectable that represents tools that can perform actions
    public abstract class Tool : Collectable
    {
        // Constrictor passes description to base class Collectable constructor
        protected Tool(string description) : base(description) { }

        public abstract void DoAction();

        public abstract override void AddMe(List<Collectable> list);

    }
}

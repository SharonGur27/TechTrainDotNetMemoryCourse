using System.Collections.Generic;

namespace Manufacturing.Gadgets
{
    public class IronManSuit : HighTechGadget
    {
        public IronManSuit()
        {
            Name = "Iron Man Suit";
            Model = "Mark L";
            Weight = 50000; 
            RaiseProducedEvent();
        }

        public override string GetDescription()
        {
            return $"{Name} - {Model} model, {Weight} grams";
        }
    }
}
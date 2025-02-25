using System.Collections.Generic;

namespace Manufacturing.Gadgets
{
    public class IronManSuit : HighTechGadget
    {
        private static List<string> _components = new List<string>();

        public IronManSuit()
        {
            Name = "Iron Man Suit";
            Model = "Mark L";
            Weight = 50000; // 50 kg
            _components.Add("Repulsor"); // Redundant allocation
            _components.Add("JARVIS"); // Redundant allocation
            _components.Add("Armor"); // Redundant allocation
            RaiseProducedEvent();
        }

        public override string GetDescription()
        {
            return $"{Name} - {Model} model, {Weight} grams";
        }
    }
}
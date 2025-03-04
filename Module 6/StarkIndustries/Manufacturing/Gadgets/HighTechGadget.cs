using System;

namespace Manufacturing.Gadgets
{
    public abstract class HighTechGadget
    {
        public event EventHandler OnProduced;

        public string Name { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; } 

        protected void RaiseProducedEvent()
        {
            OnProduced?.Invoke(this, EventArgs.Empty);
        }

        public abstract string GetDescription();
    }
}
using System;

namespace WilliWonkaChocolateFactory.Candies
{
    public abstract class Candy
    {
        public event EventHandler? OnProduced;

        public string? Name { get; set; }
        public string? Flavor { get; set; }
        public int Weight { get; set; } // in grams

        protected void RaiseProducedEvent()
        {
            OnProduced?.Invoke(this, EventArgs.Empty);
        }

        public abstract string GetDescription();
    }
}
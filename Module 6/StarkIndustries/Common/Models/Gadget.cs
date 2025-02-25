namespace Common.Models
{
    public abstract class Gadget
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; } // in grams

        public abstract string GetDescription();
    }
}
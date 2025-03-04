using System.Collections.Generic;

namespace WilliWonkaChocolateFactory.Utils
{
    public class CandyData
    {
        public string Name { get; set; }
        public string Flavor { get; set; }
        public int Weight { get; set; }
        public List<string> Ingredients { get; set; }
    }
}
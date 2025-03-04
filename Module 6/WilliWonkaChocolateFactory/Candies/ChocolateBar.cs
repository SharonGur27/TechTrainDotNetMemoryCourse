using System.Collections.Generic;
using System.Formats.Asn1;
using System.IO;
using System.Text.Json;
using WilliWonkaChocolateFactory.Utils;

namespace WilliWonkaChocolateFactory.Candies
{
    public class ChocolateBar : Candy
    {
        private static List<string> _ingredients = new List<string>(1000);

        public ChocolateBar()
        {
            var json = JsonReader.ReadJson("../../../data/chocolateBar.json");
            var memoryStream = new MemoryStream(System.Text.Encoding.UTF8.GetBytes(json));
            var candyData = JsonSerializer.Deserialize<CandyData>(memoryStream);

            Name = candyData!.Name;
            Flavor = candyData.Flavor;
            Weight = candyData.Weight;
            _ingredients.AddRange(candyData.Ingredients);

            RaiseProducedEvent();
        }

        public override string GetDescription()
        {
            return $"{Name} - {Flavor} flavor, {Weight} grams";
        }
    }
}
using System.Formats.Asn1;
using System.IO;
using System.Text.Json;
using WilliWonkaChocolateFactory.Utils;

namespace WilliWonkaChocolateFactory.Candies
{
    public class Lollipop : Candy
    {
        public Lollipop()
        {
            var json = JsonReader.ReadJson("../../../data/lollipop.json");
            var memoryStream = new MemoryStream(System.Text.Encoding.UTF8.GetBytes(json));
            var candyData = JsonSerializer.Deserialize<CandyData>(memoryStream);

            Name = candyData!.Name;
            Flavor = candyData.Flavor;
            Weight = candyData.Weight;

            RaiseProducedEvent();
        }

        public override string GetDescription()
        {
            return $"{Name} - {Flavor} flavor, {Weight} grams";
        }

        ~Lollipop()
        {
            Console.WriteLine("Lollipop is being destroyed!");
        }
    }
}
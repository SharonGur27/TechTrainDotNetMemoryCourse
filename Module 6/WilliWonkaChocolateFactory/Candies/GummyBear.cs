using System;
using System.Formats.Asn1;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.Json;
using WilliWonkaChocolateFactory.Utils;

namespace WilliWonkaChocolateFactory.Candies
{
    public class GummyBear : Candy
    {
        private IntPtr _unmanagedMemory;

        public GummyBear()
        {
            var json = JsonReader.ReadJson("../../../data/gummyBear.json");
            var memoryStream = new MemoryStream(System.Text.Encoding.UTF8.GetBytes(json));
            var candyData = JsonSerializer.Deserialize<CandyData>(memoryStream);

            Name = candyData!.Name;
            Flavor = candyData.Flavor;
            Weight = candyData.Weight;

            _unmanagedMemory = Marshal.AllocHGlobal(1024 * 1024); // Allocate 1MB

            RaiseProducedEvent();
        }

        public override string GetDescription()
        {
            return $"{Name} - {Flavor} flavor, {Weight} grams";
        }
    }
}
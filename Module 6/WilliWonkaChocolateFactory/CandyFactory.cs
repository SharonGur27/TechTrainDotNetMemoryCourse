using System.Collections.ObjectModel;
using WilliWonkaChocolateFactory.Candies;

namespace WilliWonkaChocolateFactory
{
    public class CandyFactory
    {
        private List<Candy> _candies = [];
        private Timer? _productionTimer;
        private static object _syncObject = new object();

        public void StartProduction()
        {
            _productionTimer = new Timer(ProduceCandy, null!, 0, 1);
        }

        private void ProduceCandy(object? state)
        {
            var candy = CreateRandomCandy();
            lock (_syncObject)
            {
                _candies.Add(candy);
            }
            candy.OnProduced += Candy_OnProduced;
        }

        private void Candy_OnProduced(object? sender, EventArgs e)
        {
            if (sender is Candy candy)
            {
                Console.WriteLine($"{candy.Name} produced!");
            }
        }

        private Candy CreateRandomCandy()
        {
            var random = new Random();
            switch (random.Next(3))
            {
                case 0:
                    return new ChocolateBar();
                case 1:
                    return new GummyBear();
                case 2:
                    return new Lollipop();
                default:
                    return new ChocolateBar();
            }
        }

        public void StopProduction()
        {
            _productionTimer.Change(Timeout.Infinite, Timeout.Infinite);
        }

        public void DisplayProducedCandies()
        {
            lock (_syncObject)
            {
                foreach (var candy in _candies)
                {
                    Console.WriteLine(candy.GetDescription());
                }
            }
        }
    }
}